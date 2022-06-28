using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RepoDb;
using IdentityCustomDatabase.Repositories.Interfaces;
using RepoDb.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace IdentityCustomDatabase.Repositories
{
    public class GenericRepository<T, KeyType> : BaseRepository<T, SqlConnection>, IGenericRepository<T, KeyType>
        where T : class
        where KeyType : struct
    {

        public GenericRepository(IConfiguration configuration) : base(configuration.GetConnectionString("CustomIdentity"))
        {
        }

        public async Task<T> Get(KeyType id)
        {
            var entityResult = await base.QueryAsync(id);
            return entityResult.First();
        }

        public async Task<(IEnumerable<T> PageList, int PageCount)> GetPaginated(int pageSize, int page, List<OrderField> orderBy)
        {
            using var connection = base.CreateConnection();
            var pagedList = await connection.BatchQueryAsync<T>(page: page - 1, rowsPerBatch: pageSize, orderBy: orderBy, where: new QueryField[0]);

            var totalCount = await base.CountAllAsync();

            var totalPages = (totalCount + (pageSize - 1)) / pageSize;

            return (pagedList, (int)totalPages);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var entities = await base.QueryAllAsync();
            return entities;
        }

        public async Task<KeyType> Create(T entity)
        {
            return await base.InsertAsync<KeyType>(entity);
        }

        public async Task<int> Update(T entity)
        {
            return await base.UpdateAsync(entity);
        }

        public async Task<int> Delete(T entity)
        {

            return await base.DeleteAsync(entity);
        }
    }
}
