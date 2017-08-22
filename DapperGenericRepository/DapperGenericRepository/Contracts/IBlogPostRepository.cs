using System.Collections.Generic;
using DapperGenericRepository.Domain;

namespace DapperGenericRepository.Contracts
{
    public interface IBlogPostRepository
    {
        void Insert(BlogPost entity);
        void Delete(BlogPost entity);
        void Update(BlogPost entity);
        IEnumerable<BlogPost> Query(string where = null);
        int TotalComments(int blogPostId);
    }
}
