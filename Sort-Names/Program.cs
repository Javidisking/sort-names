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
                var cs = new ContactService();

                //Reading Source                
                var contacts = cs.ReadFile(args[0]);

                //Displaying
                cs.DisplayContacts(contacts);

                
            }
            catch (InvalidFileTypeException ex)
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
