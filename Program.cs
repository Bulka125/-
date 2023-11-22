class Program
{
    static void Main()
    {
        Console.Write("Введите строки через запятую: ");
        string input = Console.ReadLine();

        // Разбиваем введенные строки на массив строк
        string[] inputArray = input.Split(',');

        // Формируем новый массив из строк длиной не более 3 символов
        string[] resultArray = FilterStrings(inputArray);

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (var str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        // Считаем количество строк, удовлетворяющих условию
        int count = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] resultArray = new string[count];

        // Заполняем новый массив строками, удовлетворяющими условию
        int index = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index++] = str;
            }
        }

        return resultArray;
    }
}
