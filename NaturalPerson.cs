using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{

    internal class NaturalPerson : Counterparty
    {  
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }  

        public NaturalPerson() { 
            
        } 

        public List<NaturalPerson> GetPersonFromFile(string filePath)
        { 
            if (!IsFileExtensionValid(filePath))
            {
                throw new Exception("File extension error");
            }
            List<NaturalPerson> naturalPeople = new List<NaturalPerson>();
            var lines = File.ReadLines(filePath);
            foreach (var line in lines)
            {
                var person = new NaturalPerson();
                var items = line.Split('|');
                for (int i =0; i < items.Length; i++)
                {
                    person.BIN_IIN = items[0];
                    person.DateCreate = Convert.ToDateTime(items[1]);
                    person.FirstName = items[2].Split(' ')[0];
                    person.MiddleName = items[2].Split(' ')[2];
                    person.LastName = items[2].Split(' ')[1];
                }
                naturalPeople.Add(person);
            }
            return naturalPeople;
        }
    }
}
