using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LegalEntity : Counterparty
    {
        private string NameOrganization;

        public LegalEntity(int id, string bin_iin, DateTime dateCreate, string nameOrganization) : base(id, bin_iin, dateCreate)
        {
            NameOrganization = nameOrganization;
        }
    }
}
