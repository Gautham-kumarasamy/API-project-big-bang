using final333.MODEL;
using System.Collections.Generic;
using System.Linq;

namespace final333.SERVICES
{
    public class UserService : IUserService
    {
        private readonly Hoteldbcontext _context;

       public UserService(Hoteldbcontext context)
        {
            _context = context;
        }

        public  User GetUserById(int customerId)
        {
            return _context.user.Find(customerId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.user.ToList();
        }

        public void CreateUser(User user)
        {
            _context.user.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.user.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int customerId)
        {
            var user = _context.user.Find(customerId);
            if (user != null)
            {
                _context.user.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
