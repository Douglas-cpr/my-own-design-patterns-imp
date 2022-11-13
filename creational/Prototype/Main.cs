namespace Prototype;

public interface IBook
{
  IBook Clone();
}

public abstract class Book : IBook
{
  public string Title { get; set; }
  public string Author { get; set; }
  public int PagesNumber { get; set; }

  public Book(string title, string author, int pagesNumber)
  {
    Title = title;
    Author = author;
    PagesNumber = pagesNumber;
  }

  public abstract IBook Clone(); 
}

public class FireAndBlood : Book
{

  public FireAndBlood(string title, string author, int pagesNumber) : base(title, author, pagesNumber) {}

  public override IBook Clone()
  {
    return new FireAndBlood(this.Title, this.Author, this.PagesNumber);
  }
}

public class Hobbit : Book
{
  public Hobbit(string title, string author, int pagesNumber) : base(title, author, pagesNumber) {}

  public override IBook Clone()
  {
    return new Hobbit(this.Title, this.Author, this.PagesNumber);
  }
}

public class Main 
{
  public Main()
  {
    var book = new FireAndBlood("Fire and Blood", "George Martin", 372);
    var cloned = book.Clone();
  }
}