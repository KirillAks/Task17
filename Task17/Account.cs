using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Account<T>
    {
        private T Num { get; set; }
        private int Balance { get; set; }
        private string Name { get; set; }

        public string Print()
        {
            return $"Номер счёта: {Num} Баланс счёта: {Balance} ФИО владельца счёта: {Name}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счёта");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Укажите баланс");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца счёта");
            Name = Console.ReadLine();
        }
    }
}
