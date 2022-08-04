using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_CassioCorrea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyConnector connector = new MyConnector();
            IOrganizationService service = connector.createConnection();
            
            Account account = new Account();         

            Guid accountId = service.Create(account.createAccount());

            Console.WriteLine(account.toString());

            bool error = false;
            do
            {
                error = false;
                Console.Write("\nDeseja criar um contato para essa conta? (S/N)");
                String choice = Console.ReadLine();
                if (choice.ToUpper() == "S")
                    {
                        Contact contact = new Contact();                        
                        service.Create(contact.createContact(accountId));
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
