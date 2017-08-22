using System;
using DapperGenericRepository.Contracts;
using DapperGenericRepository.Domain;
using DapperGenericRepository.Repositories;

namespace DapperGenericRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            // get new repository instance
            IBlogPostRepository repository = new BlogPostRepository();

            // insert
            var newEntity = new BlogPost { Title = "How to implement a repository", Description = "In this post we will talk about repositories" };
            repository.Insert(newEntity);

            //select
            var posts = repository.Query();

            //total of comments of the first post
            var totalCommentsOfFirstPost = repository.TotalComments(1);

            foreach (var post in posts)
                Console.WriteLine($"{post.Title} - {post.Description}");

            Console.WriteLine();
            Console.WriteLine($"The first post has {totalCommentsOfFirstPost} comments");

            Console.WriteLine();
            Console.WriteLine("end...");
            Console.ReadLine();
        }
    }
}
