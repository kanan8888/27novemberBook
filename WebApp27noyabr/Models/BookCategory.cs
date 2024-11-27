namespace WebApp27noyabr.Models
{
    public class BookCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Book> Books { get; set;}

    }
}
