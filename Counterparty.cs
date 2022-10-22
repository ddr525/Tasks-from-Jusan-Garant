using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{

    internal class Counterparty
    {
        public List<string> FileExtensions = new List<string>
        {
            ".txt",
        };
         
        public string BIN_IIN { get; set; }
        public DateTime DateCreate { get; set; }

        protected bool IsFileExtensionValid(string filePath)
        {
            Path.GetExtension(filePath);
            if (!FileExtensions.Contains(Path.GetExtension(filePath)))
            {
                return false;
            }

            return true;
        }
    }
}
