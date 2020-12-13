namespace Team_Todo_Management.ViewModels
{
    public class BaseQueryModel
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 20;
    }
}