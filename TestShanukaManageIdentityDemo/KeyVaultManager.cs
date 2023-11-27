using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Threading.Tasks;

namespace TestShanukaManageIdentityDemo
{
    public class KeyVaultManager : IKeyVaultManager
    {
        private readonly SecretClient _secretClient;
        public KeyVaultManager(SecretClient secretClient)
        {
            _secretClient = secretClient;
        }


        public async Task<string> GetSecret(string secretName)
        {
            try
            {
               // var client = new SecretClient(vaultUri: new Uri(data.KeyVaultUrl), credential: new DefaultAzureCredential());

                KeyVaultSecret keyValueSecret = await _secretClient.GetSecretAsync(secretName);
                return keyValueSecret.Value;
            }

            catch
            {

                throw;

            }
        }
    }
}
