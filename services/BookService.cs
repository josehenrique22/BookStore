using DTO;

namespace Services;

public class BookService
{
    public BookDTO BookInformation(string _bookName, 
    string _author, string _genre, string _price)
    {
        return new BookDTO(_bookName, _author, _genre, _price);
    }

}