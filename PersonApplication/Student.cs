using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    // Student periytyy Person-luokasta
    // Student on aliluokka, Person on yli/kantaluokka
    // Student saa kaikki Person-luokan ominaisuudet ja toiminnot
    // -riippuen suojamääreistä (esim private)
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {
        }

        public Student(string firstname, string lastname, string address, string studentID)
            : base(firstname,lastname,address)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("Learning OOP!");
        }

        // ylikirjoitetaan Person-luokassa oleva ToSting()-metodi
        public override string ToString()
        {
            // yli- eli Person-luokasta palautuu
            // Firstname Lastname Address
            // Lisätään studentin oma ID
            return base.ToString() + " " + StudentID;
            
        }

    }
}
