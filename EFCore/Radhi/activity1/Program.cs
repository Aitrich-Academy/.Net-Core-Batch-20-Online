using activity1.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        var Db = new LibraryContext();
        var Db1=new LibraryContext();
        Db1.Author.Add(new Author { Name = "Manju" });
        Db1.SaveChanges();

      
       
        Db.Books.Add(new Book { Title = "MT vasudevan nair", Genre = "Novel", AuthorId = 1 });
        Db.SaveChanges();


    }
}