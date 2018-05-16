namespace CityInfo.API.Services.Contracts
{
    public interface IMailService
    {
        void Send(string subject, string message);
    }
}
