using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactHelper
{
    public interface IContactService
    {
        List<Contact> ReadFile(string filepath);
        void DisplayContacts(List<Contact> contacts);
        List<Contact> Sort(List<Contact> contacts, Func<Contact, string> orderBySelector, Func<Contact, string> thenSelector);
    }
}
