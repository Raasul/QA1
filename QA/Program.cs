using QA;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            decimal num1 = decimal.Parse(Console.ReadLine()); // Ввод первого числа с консоли

            Console.WriteLine("Введите второе число:");
            decimal num2 = decimal.Parse(Console.ReadLine()); // Ввод второго числа с консоли

            Console.WriteLine("Выберите арифметическую операцию (+, -, *, /):");
            char operation = Console.ReadLine()[0];

            BigInteger<decimal> bigInt1 = new BigInteger<decimal>(num1); // Создание объекта BigInteger с первым числом
            BigInteger<decimal> bigInt2 = new BigInteger<decimal>(num2); // Создание объекта BigInteger со вторым числом

            BigInteger<decimal> result; // Результат операций 

            switch (operation) //Выбор арифметической операции
            {
                case '+':
                    result = bigInt1 + bigInt2;
                    Console.WriteLine("Сумма: " + result.Value);
                    break;
                case '-':
                    result = bigInt1 - bigInt2;
                    Console.WriteLine("Сумма: " + result.Value);
                    break;
                case '*':
                    result = bigInt1 * bigInt2;
                    Console.WriteLine("Сумма: " + result.Value);
                    break;
                case '/':
                    if (!EqualityComparer<decimal>.Default.Equals(num2, 0)) // Проверка на деление на ноль
                    {
                        result = bigInt1 / bigInt2; // Выполнение операции деления
                        Console.WriteLine("Результат: " + result.Value); // Вывод результата деления
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль недопустимо."); // Вывод сообщения об ошибке при делении на ноль
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка:");
                    break;
            }
        }
        catch (Exception ex) // Обработка исключений
        {
            Console.WriteLine("Ошибка: " + ex.Message); // Вывод сообщения об ошибке
        }
    }
}