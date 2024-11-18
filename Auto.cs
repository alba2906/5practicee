using _5practicee;
using System;
//производный класс
public class Auto : Transport
{
    int modelyear;
    //конструктор
    public Auto(string firma = "Неизвестный", string model = "Неизвестный", int price = 0, int speed = 0, int modelyear = 0)
        : base(firma, model, price, speed)
    {
        Modelyear = modelyear;
    }
    public override void PrintInfo()
    {

        base.PrintInfo();
        Console.WriteLine($"Год выпуска: {modelyear}");
    }
    //свойства get и set 
    public int Modelyear
    {
        set
        {
            if (value > 0)
            {
                modelyear = value;
            }
            else
            {
                Console.WriteLine("Неккоректный год выпуска.Эта характеристика будет равна 0");
                modelyear = 0;
            }
        }
        get { return modelyear; }
    }
    // метод для добавления автомобиля
    public static List<Transport> AddAuto(List<Transport> transport)
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
                Console.WriteLine("Неверная цена. Попробуйте снова.");
                continue;
            }

            Console.Write("Введите максимальную скорость (км/ч): ");
            if (!int.TryParse(Console.ReadLine(), out int speed))
            {
                Console.WriteLine("Неверная максимальная скорость (км/ч). Попробуйте снова. ");
                continue;
            }

            Console.Write("Введите год выпуска: ");
            if (!int.TryParse(Console.ReadLine(), out int modelyear))
            {
                Console.WriteLine("Неверный год выпуска. Попробуйте снова.");
                continue;
            }

            Auto newAuto = new Auto(firma, model, price, speed, modelyear);
            transport.Add(newAuto);
            Console.WriteLine("Автомобиль добавлен в список.\n");
            validInput = true;
        }
        return transport;
    }
}




