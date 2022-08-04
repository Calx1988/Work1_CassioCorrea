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
        string firstName;
        string lastName;
        string email;
        string jobTitle;

        public Contact()
        {
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public override string ToString()
        {
            string result = "\n\t------Contato Criado------"
                + "\nNome: " + lastName + ", " + firstName
                + "\nEmail: " + email
                + "\nCargo: " + jobTitle;

            return result;
        }

    }
}
