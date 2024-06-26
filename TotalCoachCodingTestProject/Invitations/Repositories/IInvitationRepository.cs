using TotalCoachCodingTestProject.Models;

namespace TotalCoachCodingTestProject.Invitations.Repositories
{
    public interface IInvitationRepository
    {
        public Task<Invitation> GetInvitationByIdAsync(string invitationId);
    }
}