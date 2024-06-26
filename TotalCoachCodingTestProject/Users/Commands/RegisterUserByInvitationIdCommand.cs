using MediatR;
using TotalCoachCodingTestProject.Models;

namespace TotalCoachCodingTestProject.Users.Commands
{
    public class RegisterUserByInvitationIdCommand : IRequest<User>
    {
        public string InvitationId { get; set; }

        public RegisterUserByInvitationIdCommand(string invitationId)
        {
            InvitationId = invitationId;
        }
    }
}
