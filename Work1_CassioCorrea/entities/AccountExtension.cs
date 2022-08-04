using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_CassioCorrea.entities
{
    internal static class AccountExtension
    {
        public static Entity CreateAccount(Account account)
        {
            bool error;
            Entity entity = new Entity("account");
            do
            {
                error = false;
                try
                {
                    Console.Write("Por favor, informe o nome da Conta: ");
                    account.Name = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(account.Name))
                    {
                        entity["name"] = account.Name;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Não pode ser vazio.");
                        error = true;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Algo errado. Erro: " + e.Message);
                    error = true;    
                } 
            } while (error);

            do
            {
                error = false;
                try
                {
                    Console.Write("Digite o telefone principal: ");
                    account.Phone = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(account.Phone))
                    {
                        entity["telephone1"] = account.Phone;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Não pode ser vazio.");
                        error = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Algo errado. Erro: " + e.Message);
                    error = true;
                } 
            } while (error);

            do
            {
                error = false;
                try
                {
                    Console.Write("Digite o Website: ");
                    account.Website = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(account.Website))
                    {
                        entity["websiteurl"] = account.Website;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Não pode ser vazio.");
                        error = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Algo errado. Erro: " + e.Message);
                    error = true;
                } 
            } while (error);

            //option
            do
            {
                error = false;
                try
                {
                    Console.Write("Categoria: (1 - Preferencial / 2 -Padrão) ");
                    account.Category = int.Parse(Console.ReadLine());
                    if (account.Category == 1 || account.Category == 2)
                    {
                        entity["accountcategorycode"] = new OptionSetValue(account.Category);
                    }
                    else {
                        Console.WriteLine("Opção inválida!"); 
                        error = true; }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Opção inválida!");
                    error = true;
                } 
            } while (error);

            //integer
            do
            {
                error=false;
                try
                {
                    Console.Write("Digite o número de funcionários: ");
                    account.NumberOfEmployees = int.Parse(Console.ReadLine());
                    entity["numberofemployees"] = account.NumberOfEmployees;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Informação inválida!");
                    error = true;
                } 
            } while (error);

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
            
            Console.Write("Digite o código da região: ");

            do
            {
                error = false;
                try
                {
                    account.TerritoryId = Guid.Parse(Console.ReadLine());
                    entity["territoryid"] = new EntityReference("territory", account.TerritoryId);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Não foi possível passar a id. Erro: " + e.Message);
                    error=true;
                } 
            } while (error);
            

            //Decimal
            do
            {
                error = false;
                try
                {
                    Console.Write("Total de oportunidades: ");
                    account.TotalOfOpportunities = decimal.Parse(Console.ReadLine());
                    entity["cc_totaldeoportunidades"] = account.TotalOfOpportunities;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Valor inválido!");
                    error=true;
                } 
            } while (error);

            return entity;
        }
    }
}
