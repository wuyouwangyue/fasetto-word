using System.Security;

namespace Fasetto.Word
{
    public interface IHavePassword
    {
        SecureString SecurePassword { get; }
    }
}
