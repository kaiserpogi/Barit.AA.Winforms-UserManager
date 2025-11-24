using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Barit.AA.Winforms_UserManager
{
    public class UserRepository
    {
        private readonly ISQLiteConnection _connection;

        public UserRepository()
        {
            _connection = new SQLiteConnection("UserDatabase.db");
            

        }
        public bool Add(User user)
        {
            return true;
        }

        public List<User> GetAll()
        {
            return new List<User>();
        }

        public User Get(int id)
        {
            return new User("DummyFullname", "DummyUsername" ,"DummyPassword");
        }

    }
}
