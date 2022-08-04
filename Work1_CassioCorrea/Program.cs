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
            
            
            Entity account = new Entity("account");
            Console.Write("Digite o nome da Conta: ");
            String name = Console.ReadLine();
            account["name"] = name;

            Console.Write("Digite o telefone: ");
            String phone = Console.ReadLine();
            account["telephone1"] = phone;

            Console.Write("Digite o Website: ");
            String site = Console.ReadLine();
            account["websiteurl"] = site;

            Console.Write("Deseja criar um contato para essa conta? (S/N)");
            String choice = Console.ReadLine();
            if(choice.ToUpper() == "S")
            {
                Guid accountId = service.Create(account);

                Entity contact = new Entity("contact");
                contact["firstname"] = "Natalia";
                contact["lastname"] = "Branisci";
                contact["jobtitle"] = "Illustrator";
                contact["parentcustomerid"] = new EntityReference("account", accountId);
                service.Create(contact);
            }else if (choice.ToUpper() == "N")
            {
                Console.WriteLine("Encerrando o programa. Obrigado!");
            }
            

        }
    }
}
