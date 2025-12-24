using Controller;

class Program
{
    private readonly static BookStoreController _bookStoreController = new();
    public static void Main(string[] args)
    {
        _bookStoreController.SystemFunctionality();
    }

}