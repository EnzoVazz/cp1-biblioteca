namespace Biblioteca.Domain.Helpers;

public class HashHelper
{
    public static string Hash(string rawSenha, string salt)
    {
        return BCrypt.Net.BCrypt.HashPassword(rawSenha + salt);
    }
    
    public static bool Verify(string rawSenha, string salt, string hashedSenha)
    {
        return BCrypt.Net.BCrypt.Verify(rawSenha + salt, hashedSenha);
    }
}