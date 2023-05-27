using final333.MODEL;
using System.Collections.Generic;

namespace final333.SERVICES
{
    public interface IUserService
    {
        User GetUserById(int customerId);
        IEnumerable<User> GetAllUsers();
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int customerId);
    }
}
