using DTO;

namespace Services;

public class BookStoreService
{

    private readonly List<ClientDTO> _accountSaved = [];
    private readonly List<BookDTO> BooksSaved = [];

    private readonly AdminService _adminAccount = new();
    private readonly BookService _bookService = new();


    public void RegisterAccount(ClientDTO _account)
    {
        _accountSaved.Add(_account);
    }

    public void AlreadyAccountRegister()
    {
        RegisterAccount(_adminAccount.AdminInformation());
    }

    public void RegisterBook(string _bookName,
    string _author, string _genre, string _price)
    {
        BooksSaved.Add(_bookService.BookInformation(_bookName, _author, _genre, _price));
    }

    public void LogAccounts()
    {
        foreach (var _accounts in _accountSaved)
        {
            Console.WriteLine("Accounts: " + _accounts);
        }
    }

    public void BookLogs()
    {
        foreach (var _books  in BooksSaved)
        {
            Console.WriteLine("Accounts: " + _books);
        }
    }

}

