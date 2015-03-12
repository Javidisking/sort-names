using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ContactHelper;

namespace SortNames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {                
                //check if args is null or empty
                if (args == null || args.Length == 0)
                    throw new Exception("File was missing. please provide the file. e.g. sort-names c:\\names.txt");

                var cs = new ContactService();

                //Reading Source                
                var contacts = cs.ReadFile(args[0]);

                //Displaying
                cs.DisplayContacts(contacts);

                //Sorting
                var sortedcontacts = cs.Sort(contacts, x => x.LastName, x => x.FirstName);

                //Wrting To Target
                var targetFilename = Path.GetFileNameWithoutExtension(args[0]) + "-sorted.txt";
                var targetFilePath = Path.GetDirectoryName(args[0]) + "\\" + targetFilename;

                cs.WriteToFile(sortedcontacts, targetFilePath);

                Console.WriteLine("Finished: created {0}", targetFilename);

            }
            catch (InvalidFileTypeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidFileFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidPathException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
