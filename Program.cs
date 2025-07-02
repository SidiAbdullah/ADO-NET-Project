using System;
using contactsBusinessLayer;

namespace contactsPresantationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsContacts contact = clsContacts.Find(1);
            if (contact != null)
            {
                contact.printContactInfos();
            }
            else
            {
                Console.WriteLine("contact [" + 1 + "] is not found");
            }
        }
    }
}
