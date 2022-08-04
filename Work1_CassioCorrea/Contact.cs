using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_CassioCorrea
{
    internal class Contact
    {
        String firstName;
        String lastName;
        String email;
        String jobTitle;

        public Contact()
        {
        }

        public Entity createContact(Guid id)
        {
            Entity contact = new Entity("contact");
            Console.Write("Digite o primeiro nome: ");
            firstName = Console.ReadLine();
            contact["firstname"] = firstName;
            Console.Write("Digite o sobrenome: ");
            lastName = Console.ReadLine();
            contact["lastname"] = lastName;
            Console.Write("Digite o cargo: ");
            jobTitle = Console.ReadLine();
            contact["jobtitle"] = jobTitle;
            contact["parentcustomerid"] = new EntityReference("account", id);
            return contact;
        }

    }
}
