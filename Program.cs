using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            NaturalPerson naturalPerson = new NaturalPerson();
            List<NaturalPerson> allNaturalPeople = naturalPerson.GetPersonFromFile("NaturalPeople.txt")
                .OrderBy(col => col.LastName)
                .ThenBy(prop => prop.FirstName)
                .ThenBy(prop => prop.MiddleName).ToList();

            Console.WriteLine("View all sorded users: ");
            foreach (var user in allNaturalPeople)
            {
                Console.WriteLine($"{user.LastName} {user.FirstName} {user.MiddleName}");
            }

            LegalEntity legalEntity = new LegalEntity();
            List<LegalEntity> allLegalEntity = legalEntity.GetEntitiesFromFile("LegalEntity.txt");
             
            // Доделать пункт 4 и 5
        }
    }
}
