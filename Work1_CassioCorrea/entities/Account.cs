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
        private string name;
        private string phone;
        private string website;
        private int category;
        private int numberOfEmployees;
        private decimal totalOfOpportunities;
        private Guid territoryId = new Guid();

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Website { get => website; set => website = value; }
        public int Category { get => category; set => category = value; }
        public int NumberOfEmployees { get => numberOfEmployees; set => numberOfEmployees = value; }
        public decimal TotalOfOpportunities { get => totalOfOpportunities; set => totalOfOpportunities = value; }
        public Guid TerritoryId { get => territoryId; set => territoryId = value; }

        public override String ToString()
        {
            String result = "\n\t------Criada a conta------\n"
                + "\nNome da Conta: " + Name
                + "\nTelefone Principal: " + Phone
                + "\nWebite: " + Website
                + "\nCategoria: " + Category
                + "\nFuncionários: " + NumberOfEmployees
                + "\nCódigo da Região: " + TerritoryId
                + String.Format("\nTotal de Oportunidades: {0:F2}", TotalOfOpportunities);
            return result;
        }
    }
}
