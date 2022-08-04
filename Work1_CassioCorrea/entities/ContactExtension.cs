using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_CassioCorrea.entities
{
    internal static class ContactExtension
    {
        public static Entity CreateContact(Guid id, Contact contact)
        {
            Entity entity = new Entity("contact");
            bool error;
            do
            {
                error = false;
                Console.Write("Digite o primeiro nome: ");
                contact.FirstName = Console.ReadLine();
                if (!String.IsNullOrEmpty(contact.FirstName))
                {
                    entity["firstname"] = contact.FirstName;
                }
                else
                {
                    Console.WriteLine("Não pode ser vazio!");
                    error = true;
                }
            } while (error);

            do
            {
                error = false;
                Console.Write("Digite o sobrenome: ");
                contact.LastName = Console.ReadLine();
                if (!String.IsNullOrEmpty(contact.LastName))
                {
                    entity["lastname"] = contact.LastName;
                }
                else
                {
                    Console.WriteLine("Não pode ser vazio!");
                    error = true;
                }
            } while (error);

            do
            {
                error = false;
                Console.Write("Digite o email: ");
                contact.Email = Console.ReadLine();
                if (!String.IsNullOrEmpty(contact.Email))
                {
                    entity["emailaddress1"] = contact.Email;
                }
                else
                {
                    Console.WriteLine("Não pode ser vazio!");
                    error = true;
                }
            } while (error);

            do
            {
                error=false;
                Console.Write("Digite o cargo: ");
                contact.JobTitle = Console.ReadLine();
                if (!String.IsNullOrEmpty(contact.JobTitle))
                {
                    entity["jobtitle"] = contact.JobTitle;
                }
                else
                {
                    Console.WriteLine("Não pode ser vazio!");
                    error = true;
                }
            } while (error);

            entity["parentcustomerid"] = new EntityReference("account", id);

            return entity;
        }
    }
}
