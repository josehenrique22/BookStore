using Entities;
using Services;

namespace Controller;

public class BookStoreController
{
    private static readonly BookStore _bookStore = new();
    private static readonly BookStoreService _bookStoreService = new();

    bool _sistemaAtivo = true;
    public void SystemFunctionality()
    {
        _bookStore.BusBookStore();

        while (_sistemaAtivo)
        {
            Console.WriteLine("Bem vindo ao Sistema de livraria, Oque deseja: ");
            Console.WriteLine("Login | Register | Exit (1, 2, 3)");
            string firstChoise = Console.ReadLine() ?? string.Empty;

            if (firstChoise.Equals("1"))
            {
                Console.WriteLine("Bem vindo");
                _sistemaAtivo = false;
            }

            else if (firstChoise.Equals("2"))
            {
                Console.WriteLine("Login: ");
                Console.WriteLine("Senha: ");
                string loginRegister = Console.ReadLine() ?? string.Empty;
                string passwordRegister = Console.ReadLine() ?? string.Empty;
                _bookStoreService.RegisterAccount(false, loginRegister, passwordRegister);

                Console.WriteLine("\n");
                _bookStoreService.LogAccounts();
                continue;
            }

            else if (firstChoise.Equals("3")) { _sistemaAtivo = false; }


            // System.Console.WriteLine("Registre um livro: Nome do livro, nome do author, genero do livro, preço");
            // Console.WriteLine("Nome do livro:");
            // string bookName = Console.ReadLine() ?? string.Empty;

            // Console.WriteLine("Autor:");
            // string author = Console.ReadLine() ?? string.Empty;

            // Console.WriteLine("Gênero:");
            // string genre = Console.ReadLine() ?? string.Empty;

            // Console.WriteLine("Preço:");
            // string price = Console.ReadLine() ?? string.Empty;

            // _bookStoreService.RegisterBook(
            //     bookName,
            //     author,
            //     genre,
            //     price
            // );

            // Console.WriteLine("Deseja cadastrar outro livro? (s/n)");
            // string option = Console.ReadLine() ?? "n";

            // if (option.ToLower() != "s")
            // {
            //     _bookStoreService.BookLogs();
            //     _sistemaAtivo = false;
            // }

        }
    }

}