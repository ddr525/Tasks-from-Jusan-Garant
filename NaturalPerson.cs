using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class NaturalPerson : Counterparty
    {
        private int Id { get; set; }
        private string BIN_IIN { get; set; }
        private DateTime DateCreate { get; set; }

        public  string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public NaturalPerson(int id, string bin_iin, DateTime dateCreate, string firstName, string middleName, string lastName) : base(id, bin_iin, dateCreate)
        {
            Id = id;
            BIN_IIN = bin_iin;
            DateCreate = dateCreate;

            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public List<NaturalPerson> ViewSortedNaturalPersons(List<NaturalPerson> naturalPeople)
        {
            return naturalPeople.OrderBy(col => col.LastName).ThenBy(prop => prop.FirstName).ThenBy(prop => prop.MiddleName).ToList();
        }
    }
}
