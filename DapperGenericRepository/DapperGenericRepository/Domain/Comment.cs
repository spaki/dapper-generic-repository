namespace DapperGenericRepository.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
