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
            //    var temp = new string[] { "C:\\temp\\jayjay.txt" };
            //    args = temp;

                var cs = new ContactService();

                //Reading Source                
                var contacts = cs.ReadFile(args[0]);

                //Displaying
                cs.DisplayContacts(contacts);

                //Sorting
                var sortedcontacts = cs.Sort(contacts, x => x.LastName, x => x.FirstName);

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
            Console.ReadKey();
        }
    }
}
