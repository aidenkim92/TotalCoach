
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using TotalCoachCodingTestProject.Models;
using TotalCoachCodingTestProject.Models.DataBase;

namespace TotalCoachCodingTestProject.Invitations.Repositories
{
    public class InvitationRepository : IInvitationRepository
    {
        private readonly IMongoQueryable<Invitation> _invitationCollection;
        public InvitationRepository(IOptions<InvitationDataBaseSettings> invitationDataBaseSettings)
        {
            var mongoClient = new MongoClient(
           invitationDataBaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                invitationDataBaseSettings.Value.DatabaseName);

            _invitationCollection = mongoDatabase.GetCollection<Invitation>(
                invitationDataBaseSettings.Value.CollectionName).AsQueryable<Invitation>();
            invitationDataBaseSettings.Value.SettingsPrint();
        }

        public async Task<Invitation> GetInvitationByIdAsync(string invitationId)
        {
            Console.WriteLine("check");
            var result = await _invitationCollection.Where(x => x.InvitationId == invitationId).FirstOrDefaultAsync();
            return result;
        }
    }
}