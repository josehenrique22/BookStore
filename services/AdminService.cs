using DTO;
using ServiceInterfaces;

namespace Services;

public class AdminService : ISaldo
{

    private readonly ClientDTO _adminRegisterInformation =
         new AdminDTO(true, "admin", "admin");

    public ClientDTO AdminInformation()
    {
        return _adminRegisterInformation;
    }

    public float Saldo(float _money)
    {
        return _money;
    }

}