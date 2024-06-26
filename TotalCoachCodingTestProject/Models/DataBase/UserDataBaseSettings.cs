namespace TotalCoachCodingTestProject.Models.DataBase
{
    public class UserDataBaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string CollectionName { get; set; }

        public void SettingsPrint()
        {
            Console.WriteLine($"DataBase connected to: {DatabaseName} {CollectionName}");
        }
    }
}

