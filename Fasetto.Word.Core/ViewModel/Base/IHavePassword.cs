using System.Security;

namespace Fasetto.Word.Core
{
    public interface IHavePassword
    {
        SecureString SecurePassword { get; }
    }
}
