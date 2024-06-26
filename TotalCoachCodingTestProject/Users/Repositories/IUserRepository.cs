using TotalCoachCodingTestProject.Models;

namespace TotalCoachCodingTest.Repositories
{
    public interface IUserRepository
    {
        public Task<User> RegisterUserAsync(User user);
    }
}