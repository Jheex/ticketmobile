using tickets.Models;
using System.Collections.Generic;
using System.Linq;

namespace tickets.Data
{
    public static class FakeUserStore
    {
        public static List<AppUser> Users = new List<AppUser>
        {
            new AppUser { Email = "admin@tickets.com", Password = "123456", FullName = "Administrador" },
            new AppUser { Email = "user@tickets.com", Password = "123456", FullName = "Usuário Comum" }
        };

        public static AppUser? ValidateUser(string email, string password)
        {
            return Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
