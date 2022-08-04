using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work1_CassioCorrea.entities;

namespace Work1_CassioCorrea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyConnector connector = new MyConnector();
            IOrganizationService service = connector.createConnection();
            
            Account account = new Account();         

            Guid accountId = service.Create(AccountExtension.CreateAccount(account));

            Console.WriteLine(account);

            bool error = false;
            do
            {
                error = false;
                Console.Write("\nDeseja criar um contato para essa conta? (S/N)");
                String choice = Console.ReadLine();
                if (choice.ToUpper() == "S")
                    {
                        Contact contact = new Contact();                        
                        service.Create(ContactExtension.CreateContact(accountId,contact));
                        Console.WriteLine(contact);
                    }
                else if (choice.ToUpper() == "N")
                    {
                        Console.WriteLine("\nEncerrando o programa. Obrigado!");
                    }
                else
                    {
                        error = true;
                        Console.WriteLine("\nOpção inválida!");
                    }
            }while (error);
            

        }
    }
}
