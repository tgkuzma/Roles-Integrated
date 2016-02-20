using Models;

namespace Business.Interfaces
{
    public interface IExample
    {
        User GetUser();
        User GetUserByName(string userName);
    }
}