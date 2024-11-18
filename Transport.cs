
using System;
//базовый класс
public class Transport
{
    int price, speed;
    // автоматические свойств
    public string Firma { get; set; }
    public string Model { get; set; }

    public Transport(string firma = "Неизвестный", string model = "Неизвестный", int price = 0, int speed = 0)
    {
        Firma = firma;
        Model = model;
        Price = price;
        Speed = speed;
    }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Фирма: {Firma}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Цена: {Price}");
        Console.WriteLine($"Максимальная скорость: {Speed}");
    }
    //свойства get и set 
    public int Price
    {
        set
        {
            if (value > 0)
            {
                price = value;
            }
            else
            {
                Console.WriteLine("Неккоретное значение цены. Эта характеристика будет равна 0 ");
                price = 0;
            }
        }
        get { return price; }
    }
    public int Speed
    {
        set
        {
            if (value > 0)
            {
                speed = value;
            }
            else
            {
                Console.WriteLine("Неккоректное значение скорости. Эта характеристика будет равна 0");
                speed = 0;
            }
        }
        get { return speed; }
    }
    // метод для добавления транспортного средства
    public static List<Transport> AddTransport(List<Transport> transport)
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
                Console.WriteLine("Неверная цена. Попробуйте снова. ");
                continue;
            }

            Console.Write("Введите максимальную скорость (км/ч): ");
            if (!int.TryParse(Console.ReadLine(), out int speed))
            {
                Console.WriteLine("Неверная максимальная скорость (км/ч). Попробуйте снова.");
                continue;
            }

            Transport newTransport = new Transport(firma, model, price, speed);
            transport.Add(newTransport);
            Console.WriteLine("Транспортное средство добавлен в список.\n");
            validInput = true;
        }
        return transport;
    }
    //метод для удаления транспорта
    public static List<Transport> DeleteTransport(List<Transport> transport)
    {
        bool validInput = false;
        while (!validInput)
        {
            if (transport.Count == 0)
            {
                Console.WriteLine("\nСписок пуст.\n");
            }
            else
            {
                Console.WriteLine("\nВыберите транспорт для удаления:");
                for (int i = 0; i < transport.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Фирма: {transport[i].Firma} Модель: {transport[i].Model}");
                }
                Console.Write("Введите номер транспорта: ");
                int index;
                if (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > transport.Count)
                {
                    Console.WriteLine("Неверный номер транспорта. Попробуйте снова. ");
                    continue;
                }
                transport.RemoveAt(index - 1);
                Console.WriteLine("Транспорт удален из списка.\n");
                validInput = true;
            }
        }
        return transport;
    }
    //метод для изменения характеристик транспорта
    public static List<Transport> EditTransport(List<Transport> transport)
    {
        bool validInput = false;
        while (!validInput)
        {
            if (transport.Count == 0)
            {
                Console.WriteLine("\nСписок пуст.\n");
                return transport;
            }

            Console.WriteLine("\nВыберите транспорт для изменения:");
            for (int i = 0; i < transport.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Фирма: {transport[i].Firma} Модель: {transport[i].Model}");
            }

            Console.Write("Введите номер транспорта: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > transport.Count)
            {
                Console.WriteLine("Неверный номер транспорта. Попробуйте снова. ");
                continue;
            }
            Transport selectedTransport = transport[index - 1];
            Console.WriteLine("\nВыберите характеристику для изменения:");
            Console.WriteLine("1. Фирма");
            Console.WriteLine("2. Модель");
            Console.WriteLine("3. Цена");
            Console.WriteLine("4. Скорость");
            if (selectedTransport is Escooter)
            {
                Console.WriteLine("5. Мощность");
            }
            else if (selectedTransport is Auto)
            {
                Console.WriteLine("5. Год выпуска");
            }

            Console.Write("Введите, что хотите изменить: ");
            if (!int.TryParse(Console.ReadLine(), out int set))
            {
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                continue;
            }

            switch (set)
            {
                case 1:
                    Console.Write("Введите новую фирму: ");
                    selectedTransport.Firma = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Введите новую модель: ");
                    selectedTransport.Model = Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Введите новую цену: ");
                    if (int.TryParse(Console.ReadLine(), out int newPrice))
                    {
                        selectedTransport.Price = newPrice;
                    }
                    else
                    {
                        Console.WriteLine("Неверная цена.");
                    }
                    break;
                case 4:
                    Console.Write("Введите новую скорость (км/ч): ");
                    if (int.TryParse(Console.ReadLine(), out int newSpeed))
                    {
                        selectedTransport.Speed = newSpeed;
                    }
                    else
                    {
                        Console.WriteLine("Неверная скорость.");
                    }
                    break;
                case 5:
                    if (selectedTransport is Escooter escooter)
                    {
                        Console.Write("Введите новую мощность (Вт): ");
                        if (int.TryParse(Console.ReadLine(), out int newPow))
                        {
                            escooter.Pow = newPow;
                        }
                        else
                        {
                            Console.WriteLine("Неверная мощность.");
                        }
                    }
                    else if (selectedTransport is Auto auto)
                    {
                        Console.Write("Введите новый год выпуска: ");
                        if (int.TryParse(Console.ReadLine(), out int newModelyear))
                        {
                            auto.Modelyear = newModelyear;
                        }
                        else
                        {
                            Console.WriteLine("Неверный год выпуска.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }

            Console.WriteLine("Характеристики транспорта изменены.\n");
            validInput = true;

        }
        return transport;
    }
}
