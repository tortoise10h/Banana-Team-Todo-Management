namespace Team_Todo_Management.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public int TodoId { get; set; }
    }
}