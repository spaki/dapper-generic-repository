using System.Collections.Generic;
using DapperGenericRepository.Domain;

namespace DapperGenericRepository.Contracts
{
    public interface ICommentRepository
    {
        void Insert(Comment entity);
        void Delete(Comment entity);
        void Update(Comment entity);
        IEnumerable<Comment> Query(string where = null);
    }
}
