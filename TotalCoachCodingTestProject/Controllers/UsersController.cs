using MediatR;
using Microsoft.AspNetCore.Mvc;
using TotalCoachCodingTestProject.Models;
using TotalCoachCodingTestProject.Users.Commands;

namespace TotalCoachCodingTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator mediator;

        public UsersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<User> RegisterUserByInvitationIdAsync(string invitationId, string userEmail)
        {
            var registeredUser = await mediator.Send(new RegisterUserByInvitationIdCommand(invitationId,userEmail));

            return registeredUser;
        }
    }
}