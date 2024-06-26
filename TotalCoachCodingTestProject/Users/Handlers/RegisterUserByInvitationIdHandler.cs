
using MediatR;
using TotalCoachCodingTest.Repositories;
using TotalCoachCodingTestProject.Invitations.Repositories;
using TotalCoachCodingTestProject.Models;
using TotalCoachCodingTestProject.Users.Commands;

namespace TotalCoachCodingTestProject.Users.Handlers
{
    public class RegisterUserByInvitationIdHandler : IRequestHandler<RegisterUserByInvitationIdCommand, User>
    {
        private readonly IUserRepository _userRepository;
        private readonly IInvitationRepository _invitationRepository;

        public RegisterUserByInvitationIdHandler(IUserRepository userRepository, IInvitationRepository invitationRepository)
        {
            _userRepository = userRepository;
            _invitationRepository = invitationRepository;
        }

        public async Task<User> Handle(RegisterUserByInvitationIdCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Invitation id received: {request.InvitationId}");
            Invitation invitation = null;

            try
            {
                invitation = await _invitationRepository.GetInvitationByIdAsync(request.InvitationId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (invitation == null) throw new ArgumentException($"No invitation found.");

            User newUser = new User()
            {
                UserId = Guid.NewGuid().ToString(),
                UserEmail = invitation.UserEmail,
                UserName = invitation.UserName,
                CreatedBy = invitation.CreatedBy,
                CreatedOn = DateTime.UtcNow,
                Deleted = false
            };
            
            User returnedUser = null;
            try
            {
                returnedUser = await _userRepository.RegisterUserAsync(newUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (returnedUser == null) throw new ArgumentException($"User has not registered.");

            // TODO: Delete invitation 
  
            return returnedUser;
        }
    }
}