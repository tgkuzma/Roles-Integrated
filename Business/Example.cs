using Business.Interfaces;
using Models;
using Models.Interfaces;

namespace Business
{
    public class Example : IExample  
    {
        private readonly IUserRepository _useRepository;

        public Example(IUserRepository useRepository)
        {
            _useRepository = useRepository;
        }

        public User GetUser()
        {
            return _useRepository.GetFirstUser();
        }

        public User GetUserByName(string userName)
        {
            //Obviously this should be implemented differently
            return _useRepository.GetFirstUser();
        }
    }
}
