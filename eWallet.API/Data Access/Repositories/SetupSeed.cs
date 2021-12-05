using eWallet.API.Data_Access.Repositories.Database;
using System;
using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories
{
    public class SetupSeed
    {
        // check if the database already exist else create
        // check if the table already exist else create
        // check if table is not already seeded else seed it

        public static async Task SeedMe(IADOOperations adooperations)
        {

            string stmt1 = @"
                        CREATE TABLE [User] (
                            Id nvarchar (255) PRIMARY KEY,
                            FirstName nvarchar(10) NOT NULL,
                            LastName nvarchar(10) NOT NULL,
                            Email nvarchar(255) NOT NULL,        
                            PhoneNumber nvarchar(255) NOT NULL,
                            Date_of_Birth date NOT NULL,
                            PasswordHash binary(50) NOT NULL,
                            PasswordSalt binary(50) NOT NULL
                        );

                        

                       CREATE TABLE Wallet (
                            Id nvarchar (255) PRIMARY KEY,
                            WalletType nvarchar(10) NOT NULL,
                            Status binary(50) NOT NULL
                        );


                        CREATE TABLE Currency (
                            Id nvarchar (255) PRIMARY KEY,
                            CurrencyName nvarchar(10) NOT NULL,
                            CurrencySymbol nvarchar(1) NOT NULL
                        );


                       CREATE TABLE [Transaction] (
                            Id nvarchar (255) PRIMARY KEY,
                            Sender nvarchar(10) NOT NULL,
                            Description nvarchar(10) NOT NULL,
                            TransactionType nvarchar(255) NOT NULL,        
                            Date date NOT NULL,        
                            Status binary(50) NOT NULL,        
                            Recipient nvarchar(255) NOT NULL,        
                            Amount decimal(18,0) NOT NULL
                           
                        );

                        CREATE TABLE Roles(
                            Id nvarchar (255) PRIMARY KEY,
                            RoleName nvarchar(10) NOT NULL
                        );";

            string stmt2 = @"
                        INSERT INTO [User] (Id, FirstName, LastName, Email ,PhoneNumber, Date_of_Birth, PasswordHash, PasswordSalt)
                        VALUES('189', 'John', 'Doe', 'john@doe.com', '08023456432', '2021-11-11', 0, 0);

                        
                        INSERT INTO Roles (Id, RoleName)
                        VALUES('1', 'Admin'), ('2', 'Regular');";

            try
            {
                await adooperations.ExecuteForTransactionQuery(stmt1, stmt2);
            }
            catch (Exception ex)
            {
                // log to file
                Console.WriteLine(ex.Message);
            }
        }

    }
}
