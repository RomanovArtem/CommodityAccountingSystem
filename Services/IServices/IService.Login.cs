namespace Services.IServices
{
    public partial interface IService
    {
        bool Authentication(string login, string password);
    }
}
