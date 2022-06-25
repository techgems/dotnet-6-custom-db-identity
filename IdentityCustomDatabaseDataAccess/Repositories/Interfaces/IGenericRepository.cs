using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabase.Repositories.Interfaces;

public interface IGenericRepository<EntityType, KeyType>
{
    Task<EntityType> Get(KeyType id);
    Task<(IEnumerable<EntityType> PageList, int PageCount)> GetPaginated(int pageSize, int page, List<OrderField> orderBy);
    Task<IEnumerable<EntityType>> GetAll();
    Task<KeyType> Create(EntityType entity);
    Task<int> Update(EntityType entity);
    Task<int> Delete(EntityType entity);

}

