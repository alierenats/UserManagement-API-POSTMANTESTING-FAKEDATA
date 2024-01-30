using Bogus;
using System.Collections.Generic;
using UserManagement.Models;

namespace UserManagement.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int v)
        {
            if (_users == null)
            {
                _users = new Faker<User>()
                    .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                    .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                    .RuleFor(u => u.LastName, f => f.Name.LastName())
                    .RuleFor(u => u.Address, f => f.Address.StreetAddress())
                    .Generate(v);
            }
            return _users;
        }
    }
}
