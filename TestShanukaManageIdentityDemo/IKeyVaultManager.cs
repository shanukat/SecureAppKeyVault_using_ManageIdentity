using System.Threading.Tasks;

namespace TestShanukaManageIdentityDemo
{
    public interface IKeyVaultManager
    {
        public Task<string> GetSecret(string secretName);

    }
}
