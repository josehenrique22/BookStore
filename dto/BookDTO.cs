namespace DTO;

public class BookDTO
{
    public BookDTO(string _booksName, string _autorName, string _booksGenre, string _booksPrice)
    {
        BooksName = _booksName;
        AutorName = _autorName;
        BooksGenre = _booksGenre;
        BooksPrice = _booksPrice;
    }

    public string BooksName { get; set; } = string.Empty;
    public string AutorName { get; set; } = string.Empty;
    public string BooksGenre { get; set; } = string.Empty;
    public string BooksPrice { get; set; } = string.Empty;

    public override string ToString()
    {
        return
            "\n Book Name: " + BooksName +
            "\n Author: " + AutorName +
            "\n Genre: " + BooksGenre +
            "\n Price: " + BooksPrice;
    }
}
