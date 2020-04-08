namespace DellRainInventorySystem.Interfaces
{
    interface IAccount
    {
        int AddAccount();
        int ChangePassword(string old, string newPass);
    }
}
