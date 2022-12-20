using Entities;

namespace Data
{
    public class InMemory
    {
        List<User> _users;
        public InMemory()//InMemory classı her çalıştığında otomatik oluşturulan constructorında kişileri oluşturuyoruz.
        {
            _users = new List<User>
            {
                new User { Id = 1, UserName = "Serpil", Password = "12345" },
                new User { Id = 2, UserName = "Ahmet", Password = "54321" },
                new User { Id = 3, UserName = "Duru", Password = "12345" },
                
            };

        }
        public void Add (User user)
        {
            _users.Add(user);
        }
        public List<User> GetUsers()
        {
            return _users; 
        }
        public User Get(string userName)
        {
            return _users.Find(x => x.UserName == userName);
        }

    }
}