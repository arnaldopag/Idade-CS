using System;

namespace atividade_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name, nascimento;
            DateTime today = DateTime.Today;
           

            Console.Write("Digite a seu nome: ");
            name =  Console.ReadLine();
            Console.Write("Digite a sua data de nascimento: ");
            nascimento = Console.ReadLine();
            DateTime bday = Convert.ToDateTime(nascimento);

            age = today.Year - bday.Year;
            if(today.DayOfYear < bday.DayOfYear){
                age = age - 1;
            }
            if(age < 18){
                Console.WriteLine("Suggested Password : " + name + age);
            }
            else
            {
                Console.WriteLine("Suggested Password: " + age + name);
            }
        }
    }
}
