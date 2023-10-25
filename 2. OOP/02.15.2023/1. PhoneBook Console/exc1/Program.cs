using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc1
{
    class Program
    {
        class Contact
        {
            public string name;

            public List<string> nums = new List<string>();
            public List<string> emails = new List<string>();
        }

        class PhoneBook
        {
            private List<Contact> _contacts = new List<Contact>();

            public void Add(string name, string num, string email)
            {
                Contact contact = null;

                for (int i = 0; i < _contacts.Count(); i++)
                    if (_contacts[i].name == name)
                    {
                        contact = _contacts[i];
                        break;
                    }

                if (contact == null)
                {
                    contact = new Contact
                    {
                        name = name
                    };

                    _contacts.Add(contact);
                }

                if (!String.IsNullOrEmpty(num))
                    contact.nums.Add(num);

                if(!String.IsNullOrEmpty(email))
                    contact.emails.Add(email);
            }

            public bool Find(string name, out string nums, out string emails)
            {
                nums = null;
                emails = null;

                for (int i = 0; i < _contacts.Count(); i++)
                    if (_contacts[i].name == name)
                    {
                        nums = "";
                        for (int n = 0; n < _contacts[i].nums.Count(); n++)
                            nums += _contacts[i].nums[n];

                        emails = "";
                        for (int n = 0; n < _contacts[i].emails.Count(); n++)
                            emails += _contacts[i].emails[n];

                        return true;
                    }

                return false;
            }

            public void Delete(string name)
            {
                for (int i = _contacts.Count() - 1; i >= 0; i--)
                    if (_contacts[i].name == name)
                        _contacts.RemoveAt(i);
            }
        }

        public static void Main()
        {
            var phoneBook = new PhoneBook();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("a - Add; f - Find; d - Delete; q - Quit");

                var command = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (command)
                {
                    case 'a':
                        {
                            Console.Write("Name: ");
                            var name = Console.ReadLine();

                            Console.Write("Num: ");
                            var num = Console.ReadLine();

                            Console.Write("Email: ");
                            var email = Console.ReadLine();

                            phoneBook.Add(name, num, email);
                        }
                        break;
                    case 'f':
                        {
                            Console.Write("Name: ");
                            var name = Console.ReadLine();

                            if (phoneBook.Find(name, out string num, out string email))
                            {
                                Console.WriteLine("Num: " + num);
                                Console.WriteLine("Email: " + email);
                            }
                            else
                            {
                                Console.WriteLine("Not found");
                            }

                            Console.ReadLine();
                        }
                        break;
                    case 'd':
                        {
                            Console.Write("Name: ");
                            var name = Console.ReadLine();

                            phoneBook.Delete(name);
                        }
                        break;
                    case 'q':
                        return;
                }
            }
        }
    }
}
