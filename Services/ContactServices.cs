using PhoneBook.Models;
using System;
using System.Collections.Generic;

namespace PhoneBookApp.Services
{
    /// <summary>
    /// bu class contact lar ustida amallar bajarishimizni amalga oshiradi
    /// </summary>
    public class ContactServices
    {
        private static List<PhoneContact> phoneContacts = new List<PhoneContact>();

        /// <summary>
        /// bu Method bizga contaclarimizni console oynasiga chiqarib beradi. agar ularninig soni 0 bo'lsa empty so'zi bilan
        /// </summary>
        public static void ShowAllContacts()
        {
            if (phoneContacts.Count == 0)
            {
                Console.WriteLine("Your contacts list is empty.\n");
                return;
            }
            else
            {
                Console.WriteLine("Your contact list :");
                for (int i = 0; i < phoneContacts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Name: {phoneContacts[i].Name}, Number: {phoneContacts[i].PhoneNumber}\n");
                }
            }

        }
        /// <summary>
        /// bunda biz contact listga yangi contact qo'sha olamiz.
        /// </summary>
        public static void AddContact()
        {
            Console.Write("Enter name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter number: ");
            string newNumber = Console.ReadLine();

            phoneContacts.Add(new PhoneContact { Name = newName, PhoneNumber = newNumber });
            Console.WriteLine("Contact added successfully!\n");
        }
        /// <summary>
        /// contactlarni edit qilish uchun contatct index ini so'raydi va yangilanishni kiritishni talab qiladi.
        /// </summary>
        public static void EditContact()
        {
            ShowAllContacts();
            Console.Write("Enter the index of the contact you want to edit: ");
            int index;
            // biz foydalanuvchidan input so'raymiz va uni int tipiga o'tkazishga harakayt qilamiz, o'tsa uni index ga saqlaymiz.
            if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= phoneContacts.Count)
            {
                // bizda index bo'yicha ketganda phoneContacts[index] 0 dan boshlanadi shuning uchun 1 ni ayirib qo'yamiz.
                index--;
                Console.Write("Enter new name: ");
                phoneContacts[index].Name = Console.ReadLine();

                Console.Write("Enter new number: ");
                phoneContacts[index].PhoneNumber = Console.ReadLine();

                Console.WriteLine("Contact updated successfully!\n");
            }
            else // agar input int tipiga o'ta olmasa invalid chiqaradi!
            {
                Console.WriteLine("Invalid contact number.");
            }
        }
        /// <summary>
        /// bizga keraksiz bo'lgan contactlarni indexiga qarab o'chirib yuboradi.
        /// </summary>
        public static void DeleteContact()
        {
            ShowAllContacts();
            Console.Write("Enter the index of the contact you want to delete: ");
            int index;
            // input qabul qiladi int ga o'tkazadi oraliqlarni tekshiradi
            if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= phoneContacts.Count)
            {
                index--; // berilgan sonni index ga tenglash uchun 1 ayirib tashlaydi.
                phoneContacts.RemoveAt(index); // RemoveAt index bo'yicha o'chiradi.
                Console.WriteLine("Contact deleted successfully!\n");

            }
            else
            {
                Console.WriteLine("Invalid contact number.");
            }
        }
    }
}
