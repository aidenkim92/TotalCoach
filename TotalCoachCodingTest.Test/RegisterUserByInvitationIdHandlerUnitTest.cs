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
    public async Task RegisterUserByInvitationIdHandler_Return_Registered_User()
    {
        var invitationId = "43a67f39-44ad-41aa-b916-429f260130a5"; // True data
        var expectedUserName = "Aiden";
        var expectedUserMail = "dlqnrla@gmail.com";

        // TODO: MediatR is sinked but the inner Repositories are not executed somehow - fix 
        var handler = new RegisterUserByInvitationIdHandler(_userRepositoryMock.Object, _invitationRepositoryMock.Object);

        // Act
        User result = await handler.Handle(new RegisterUserByInvitationIdCommand(invitationId), new CancellationToken());

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result.UserName, Is.EqualTo(expectedUserName));
        Assert.That(result.UserEmail, Is.EqualTo(expectedUserMail));
    }
}
