using NUnit.Framework;
using Moq;
using TotalCoachCodingTest.Repositories;
using TotalCoachCodingTestProject.Invitations.Repositories;
using TotalCoachCodingTestProject.Models;
using TotalCoachCodingTestProject.Users.Handlers;
using TotalCoachCodingTestProject.Users.Commands;
using TotalCoachCodingTestProject.Models.DataBase;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TotalCoachCodingTest.Test;
public class RegisterUserByInvitationIdHandlerUnitTest
{
    private Mock<IUserRepository> _userRepositoryMock;
    private Mock<IInvitationRepository> _invitationRepositoryMock;

    [SetUp]
    public void SetUp()
    {
        _userRepositoryMock = new();
        _invitationRepositoryMock = new();
    }

    [Test]
    public async Task RegisterUserByInvitationIdHandler_Invitation_Not_Belong_To_UserEmail()
    {
        var invitationId = "43a67f39-44ad-41aa-b916-429f260130a5"; // this belongs to "dlqnrla@gmail.com"
        var inputEmail = "abc@gmail.com";

        // TODO: MediatR is sinked but the inner Repositories are not executed somehow for nUnit test with Moq - should be fixed 
        var handler = new RegisterUserByInvitationIdHandler(_userRepositoryMock.Object, _invitationRepositoryMock.Object);

        // Assert
        Assert.ThrowsAsync<ArgumentException>(() => handler.Handle(new RegisterUserByInvitationIdCommand(invitationId, inputEmail), new CancellationToken()));
    }
}
