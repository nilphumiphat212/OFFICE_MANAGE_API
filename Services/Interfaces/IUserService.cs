using office_manage_api.Models.EF;
using System.Collections.Generic;

namespace office_manage_api.Services.Interfaces
{
    public interface IUserService
    {
        public bool AddUser(User user);
        public bool RemoveUser(int id);
        public List<User> GetAllUsers();
    }
}