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
            String accountName = Console.ReadLine();
            account["name"] = accountName;

            Console.Write("Digite o telefone: ");
            String accountPhone = Console.ReadLine();
            account["telephone1"] = accountPhone;

            Console.Write("Digite o Website: ");
            String accountSite = Console.ReadLine();
            account["websiteurl"] = accountSite;
            
            bool error = false;
            do
            {
                Console.Write("Deseja criar um contato para essa conta? (S/N)");
                String choice = Console.ReadLine();
                if (choice.ToUpper() == "S")
                    {
                        Guid accountId = service.Create(account);

                        Entity contact = new Entity("contact");
                        Console.Write("Digite o primeiro nome: ");
                        String contactName = Console.ReadLine();
                        contact["firstname"] = contactName;
                        Console.Write("Digite o sobrenome: ");
                        String contactSurname = Console.ReadLine();
                        contact["lastname"] = contactSurname;
                        Console.Write("Digite o cargo: ");
                        String contactJobTitle = Console.ReadLine();
                        contact["jobtitle"] = contactJobTitle;
                        contact["parentcustomerid"] = new EntityReference("account", accountId);
                        service.Create(contact);
                    }
                else if (choice.ToUpper() == "N")
                    {
                        Console.WriteLine("Encerrando o programa. Obrigado!");
                    }
                else
                    {
                        error = true;
                        Console.WriteLine("Opção inválida!");
                    }
            }while (error);
            

        }
    }
}
