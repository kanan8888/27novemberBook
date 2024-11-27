namespace WebApp27noyabr.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public int BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }
    }
}
