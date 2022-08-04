using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_CassioCorrea
{
    internal class Account
    {
        String name;
        String phone;
        String website;
        int category;
        int numberOfEmployees;
        decimal totalOfOpportunities;

        public Entity createAccount()
        {
            Entity account = new Entity("account");
            Console.Write("Por favor, informe o nome da Conta: ");
            name = Console.ReadLine();
            account["name"] = name;

            Console.Write("Digite o telefone principal: ");
            phone = Console.ReadLine();
            account["telephone1"] = phone;

            Console.Write("Digite o Website: ");
            website = Console.ReadLine();
            account["websiteurl"] = website;

            //option
            Console.Write("Categoria: (1 - Preferencial / 2 -Padrão) ");
            category = int.Parse(Console.ReadLine());
            account["accountcategorycode"] = new OptionSetValue(category);

            //integer
            Console.Write("Digite o número de funcionários: ");
            numberOfEmployees = int.Parse(Console.ReadLine());
            account["numberofemployees"] = numberOfEmployees;

            //LookUp Região (table-territory)
            /* 
             * Alegrete - 414cda8a-9b13-ed11-b83e-00224837621a
             * Caxias do Sul - 471ec16e-9b13-ed11-b83e-00224837621a
             * Osório - 52d1c675-9b13-ed11-b83e-00224837621a
             * Porto Alegre - e29e8c66-9b13-ed11-b83e-00224837621a
             * Rio Grande - 87ef7f7f-9b13-ed11-b83e-00224837621a
             * Santa Cruz do Sul - 4fd1c675-9b13-ed11-b83e-00224837621a
             * Santa Maria - 424cda8a-9b13-ed11-b83e-00224837621a
             * São Borja - 78f4f692-9b13-ed11-b83e-00224837621a       
             */
            /*
            Entity territory = new Entity("territory");
            Console.Write("Digite a região:");
            String territoryId = Console.ReadLine();
            account["territoryid"] = new EntityReference("territory", territoryId, territory);
            */

            //Decimal
            Console.Write("Total de oportunidades: ");
            totalOfOpportunities = decimal.Parse(Console.ReadLine());
            account["cc_totaldeoportunidades"] = totalOfOpportunities;
            return account;
        }

        public String toString()
        {
            String result = "\n\t------Criada a conta------\n"
                + "\nNome da Conta: " + name 
                + "\nTelefone Principal: " + phone 
                + "\nWebite: "+ website 
                + "\nCategoria: " + category 
                + "\nFuncionários: " + numberOfEmployees
                + String.Format("\nTotal de Oportunidades: {0:F2}", totalOfOpportunities);
            return result;
        }
    }
}
