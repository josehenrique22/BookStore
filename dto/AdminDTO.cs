namespace DTO;

public class AdminDTO : ClientDTO
{
    public AdminDTO
    (
        bool accessKey,
        string loginAccess,
        string passwordAccess
    )
        : base(accessKey, loginAccess, passwordAccess)
    {
    }

    public override string ToString()
    {
        return
        "\n Admin Access: " + AccessKey +
        "\n Login Name: " + LoginAccess +
        "\n Password: " + PasswordAccess;
    }
}
