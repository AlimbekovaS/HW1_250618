using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_240618
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание 1 или 2 (Всего 2 задания):");
            int nz = Int32.Parse(Console.ReadLine());
            
            if (nz == 1)
            {
                Console.WriteLine("5.Написать приложение, которое выведет на экран Ваше имя и фамилию. (Жду что у вас будет приложение, которое я сам запущу и где у меня попросят ввести ФИО, после я нажму Enter и мне выдастся сообщение – «Приветствую тебя - ФИО») ");
                Console.Write("Введите ФИО: ");
                string name = Console.ReadLine();
                Console.WriteLine("Приветствую тебя - " + name);
            }
            else if (nz == 2)
            {
                Console.WriteLine("6.Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму. (Так же как и в предыдущем примере, только с цифрами. Мы проходили как можно из строки перевести в число.)");
                Console.Write("Введите 3 числа ");
                int ch1 = Int32.Parse(Console.ReadLine());
                int ch2 = Int32.Parse(Console.ReadLine());
                int ch3 = Int32.Parse(Console.ReadLine());
                int sum = ch1 + ch2 + ch3;
                Console.WriteLine("Сумма чисел = " +sum);
            }
            else
            {
                Console.WriteLine("Вы ввели неверный номер задания");
            }     
        }        
    }    
}
