using System;

namespace DellRainInventorySystem.Interfaces
{
    interface IAccount
    {
        string Login(string username, string password);

        /*This method will add account the Inventory.Account
        in the database. */
        int AddAccount();

        /*This method will just update the password in the
        Inventory.Account of and specific account*/
        int ChangePassword(string old, string newPass);
    }
}
