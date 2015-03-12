﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ContactHelper
{
    public class ContactService : IContactService
    {
        public List<Contact> ReadFile(string filepath)
        {
            //Validating File Path
            Validation.ValidateFilePath(filepath);

            //Validating File Format
            Validation.ValidateFileFormat(filepath);

            var contacts = new List<Contact>();

            using (var streamreader = new StreamReader(filepath))
            {
                string line;
                while ((line = streamreader.ReadLine()) != null)
                {
                    var contact = new Contact(line.Split(',').ToList()[0].TrimStart(), line.Split(',').ToList()[1].TrimStart());
                    contacts.Add(contact);
                }
            }
            return contacts;
        }

        public void DisplayContacts(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }            
}
