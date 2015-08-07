using DotNetOpenAuth.AspNet;
using DotNetOpenAuth.AspNet.Clients;
using DotNetOpenAuth.AspNet.Extentions;
using NGM.OpenAuthentication.Models;

namespace NGM.OpenAuthentication.Services.Clients {
    public class OdnoklassnikiAuthenticationClient : IExternalAuthenticationClient
    {
        public string ProviderName {
            get { return "Odnoklassniki"; }
        }

        public IAuthenticationClient Build(ProviderConfigurationRecord providerConfigurationRecord) {
            string[] separator = new string[] {"||"};
            string[] keys = providerConfigurationRecord.ProviderSecret.Split(separator, System.StringSplitOptions.None);
            string publicKey = keys[0];
            string secretKey = keys[1];

            return new OdnoklassnikiClient(providerConfigurationRecord.ProviderIdKey, publicKey, secretKey);
        }
    }
}