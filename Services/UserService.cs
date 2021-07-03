using System.Linq;
using office_manage_api.Models.EF;
using office_manage_api.Services.Interfaces;
using System.Collections.Generic;

namespace office_manage_api.Services {
    public class UserService : IUserService {
        private DatabaseContext Db { get; }
        public UserService(DatabaseContext db) {
            this.Db = db;
        }
        public bool AddUser(User user) {
            return true;
        }
        public bool RemoveUser(int id) {
            return true;
        }
        public List<User> GetAllUsers() {
            return Db.Users.Select(s => s).ToList();
        }
    }
}