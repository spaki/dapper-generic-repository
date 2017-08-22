using DapperGenericRepository.Contracts;
using DapperGenericRepository.Domain;

namespace DapperGenericRepository.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
    }
}
