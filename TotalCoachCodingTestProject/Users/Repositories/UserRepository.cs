using MongoDB.Driver;
using Microsoft.Extensions.Options;
using TotalCoachCodingTestProject.Models.DataBase;
using TotalCoachCodingTestProject.Models;

namespace TotalCoachCodingTest.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _userCollection;
        public UserRepository(IOptions<UserDataBaseSettings> userDataBaseSettings)
        {
            var mongoClient = new MongoClient(
           userDataBaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                userDataBaseSettings.Value.DatabaseName);

            _userCollection = mongoDatabase.GetCollection<User>(
                userDataBaseSettings.Value.CollectionName);
            userDataBaseSettings.Value.SettingsPrint();
        }

        public async Task<User> RegisterUserAsync(User user)
        {
            await _userCollection.InsertOneAsync(user);

            return user;
        }
    }
}