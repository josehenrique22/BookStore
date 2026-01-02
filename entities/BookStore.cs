using Services;

namespace Entities;

public class BookStore
{
    private BookStoreService _bookStoreService = new();

    public void BusBookStore()
    {
        _bookStoreService.AlreadyAccountRegister();
    }

}