using System;
using System.Data.SqlClient;
using Dapper;
using DapperGenericRepository.Contracts;
using DapperGenericRepository.Domain;

namespace DapperGenericRepository.Repositories
{
    public class BlogPostRepository : BaseRepository<BlogPost>, IBlogPostRepository
    {
        public override void Insert(BlogPost entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Title))
                throw new Exception("The title can be empty!");
            base.Insert(entity);
        }

        public int TotalComments(int blogPostId)
        {
            var query = $"select count(*) from Comments where BlogPost_Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.ExecuteScalar<int>(query, new { Id = blogPostId });
            }
        }
    }
}
