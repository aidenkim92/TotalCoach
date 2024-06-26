# TotalCoach

Entity design and pre-saved invitation data in MongoDB

![Screenshot 2024-06-26 at 10 25 21 PM](https://github.com/aidenkim92/TotalCoach/assets/61610762/f537083b-6075-4597-9456-20a1ae88a9ce)
![Screenshot 2024-06-26 at 10 25 51 PM](https://github.com/aidenkim92/TotalCoach/assets/61610762/fd04596a-9737-4e74-9347-b6f091cdbf10)


Assumptions:
1. An invitation has already been sent to the user, and there is a record of the invitation with the fields described above.
2. When the user accepts the invitation, "InvitationId" and "UserEmail" will be provided as parameters.
3. Validation for "InvitationId" and "UserEmail" (e.g., non-empty, non-null, correct email format) has been completed when the invitation was sent to the user.
4. Folder structures follow the controller's prefix, e.g., for "UsersController", the main folder "Users" contains all user-related functionalities like "Users/Commands".
5. Since the requirement was to create a new endpoint to register the user with the invited organization, unnecessary implementations (e.g., "Create/Delete Invitation", "Create Organization") have been excluded.
6. The Invitation Repository has been implemented to demonstrate the ability to verify invitations, ensuring that a user can only accept an invitation that belongs to them.
7. LINQ was used to conditionally retrieve server data.
8. Visual Studio Code was used as the IDE.
9. Used Moq and nUnit testing for testing the Handler implementation.

Instructions for running project locally (based in Terminal)
1. Add downloaded "appsettings.json" file under the "/TotalCoachCodingTestProject" directory, e.g., "/TotalCoachCodingTestProject/appsettings.json".
2. In the terminal, navigate to the project directory by typing "cd **TotalCoachCodingTestProject**"
3. Run the project by typing "**dotnet run**"
4. Open browser and input url via "http://localhost:5176/swagger"
5. Valid Input parameters invitationId = "**43a67f39-44ad-41aa-b916-429f260130a5**" and userEmail = "**dlqnrla@gmail.com**"

Instructions for running test locally (based in Terminal)
1. At the root level of the project, type "**dotnet build**"
2. Navigate to the test project directory "**cd TotalCoachCodingTest.Test**"
3. Run the test "**dotnet test ./bin/debug/net6.0/TotalCoachCodingTest.Test.dll**"
