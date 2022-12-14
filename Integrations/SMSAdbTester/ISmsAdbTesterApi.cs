using api_authentication_boberto.Integrations.SMSAdbTester.Request;
using api_authentication_boberto.Integrations.ZenviaApiClient;
using RestEase;

namespace api_authentication_boberto.Integrations.SMSAdbTester
{
    public interface ISmsAdbTesterApi
    {
        [Post("sendsms")]
        Task EnviarSMS([Body] SendAdbTesterMessageRequest request);
    }
}
