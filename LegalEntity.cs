using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LegalEntity : Counterparty
    {
        private string NameOrganization;

        public LegalEntity() {} 

        public List<LegalEntity> GetEntitiesFromFile(string filePath)
        {
            if (!IsFileExtensionValid(filePath))
            {
                throw new Exception("File extension error");
            }

            List<LegalEntity> legalEntities = new List<LegalEntity>();

            var lines = File.ReadLines(filePath);
            foreach (var line in lines)
            {
                var person = new LegalEntity();
                var items = line.Split('|');
                for (int i = 0; i < items.Length; i++)
                {
                    person.BIN_IIN = items[0];
                    person.DateCreate = Convert.ToDateTime(items[1]);
                    person.NameOrganization = items[2].Split(' ')[0];
                }
                legalEntities.Add(person);
            }
            return legalEntities;
        }
    }
}
