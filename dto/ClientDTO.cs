namespace DTO;

public abstract class ClientDTO // Ninguem cria instancia generico, apenas herdar
{
    public bool AccessKey { get; protected set; }

    public string LoginAccess { get; protected set; } = string.Empty;
    public string PasswordAccess { get; protected set; } = string.Empty;

    protected ClientDTO
    (
        bool accessKey,
        string loginAccess,
        string passwordAccess
    )
    {
        AccessKey = accessKey;
        LoginAccess = loginAccess;
        PasswordAccess = passwordAccess;
    }
}
