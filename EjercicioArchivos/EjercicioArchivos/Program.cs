using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EjercicioArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int userNeed = 0;

            while(userNeed == (int)YesorNOt.S)
            {
                Console.WriteLine($"Do you want enter a new person Yes = {(int)YesorNOt.S} No = {(int)YesorNOt.N}");

                userNeed = Int32.Parse(Console.ReadLine());

                if (userNeed != (int)YesorNOt.S) break;

                Console.WriteLine("Write your name");

                string name = Console.ReadLine();

                Console.WriteLine("Input your age");

                int age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter your location");

                string location = Console.ReadLine();

                Person per1 = new Person(name, age, location);

                people.Add(per1);

            } 

            string personjson = JsonConvert.SerializeObject(people);

            if (File.Exists("MiArchivo.txt"))
            {
                FileStream fs = new FileStream("MiArchivo.txt", FileMode.Append);

                fs.Write(ASCIIEncoding.ASCII.GetBytes(personjson), 0, personjson.Length);

                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("MiArchivo.txt", FileMode.OpenOrCreate);

                fs.Write(ASCIIEncoding.ASCII.GetBytes(personjson), 0, personjson.Length);

                fs.Close();
            }

            
            
        }
    }
    enum YesorNOt
    {
        S,
        N
    }
}
