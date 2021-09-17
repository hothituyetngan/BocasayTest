using Bocasay.Domain.IRepositories;
using Bocasay.Domain.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Bocasay.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private const string _productDataJsonPath = "../Bocasay.Infrastructure/Data/Users.json";

        private readonly IList<User> _users;

        public UserRepository()
        {
            string data = File.ReadAllText(_productDataJsonPath);
            _users = JsonSerializer.Deserialize<List<User>>(data);
        }

        public void Create(User user)
        {
            _users.Add(user);
            string json = JsonSerializer.Serialize(_users);
            File.WriteAllText(_productDataJsonPath, json);
        }
    }
}
