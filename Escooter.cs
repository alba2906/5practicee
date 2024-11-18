using _5practicee;
using System;
//производный класс
public class Escooter : Transport
{
    private int pow;
    //конструктор
    public Escooter(string firma = "Неизвестный", string model = "Неизвестный", int price = 0, int speed = 0, int pow = 0)
        : base(firma, model, price, speed)
    {
        Pow = pow;
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Мощность (Вт): {pow}");
    }
    //свойства get и set 
    public int Pow
    {
        set
        {
            if (value > 0)
            {
                pow = value;
            }
            else
            {
                Console.WriteLine("Неккоректная мощность (Вт). Эта характеристика будет равна 0");
                pow = 0;
            }
        }
        get { return pow; }
    }
    //метод для добавления электросамоката
    public static List<Transport> AddEscooter(List<Transport> transport)
    {
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Введите фирму: ");
            string firma = Console.ReadLine();
            Console.Write("Введите модель: ");
            string model = Console.ReadLine();

            Console.Write("Введите цену (руб.): ");
            if (!int.TryParse(Console.ReadLine(), out int price))
            {
                Console.WriteLine("Неверная цена(руб.). Попробуйте снова.");
                continue;
            }

            Console.Write("Введите максимальную скорость (км/ч): ");
            if (!int.TryParse(Console.ReadLine(), out int speed))
            {
                Console.WriteLine("Неверная максимальная скорость (км/ч). Попробуйте снова.");
                continue;
            }

            Console.Write("Мощность (Вт): ");
            if (!int.TryParse(Console.ReadLine(), out int pow))
            {
                Console.WriteLine("Неверная мощность(Вт). Попробуйте снова. ");
                continue;
            }

            Escooter newEscooter = new Escooter(firma, model, price, speed, pow);
            transport.Add(newEscooter);
            Console.WriteLine("Электросамокат добавлен в список.\n");
            validInput = true;
        }
        return transport;
    }
}

