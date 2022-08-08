// Создание массива строк как входные данные.
// Основная задача
// Печать массива.

Console.Write("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());

string[] inputArray = new string[count];
for (int i = 0; i < inputArray.Length; i++)
{
    Console.WriteLine($"Введите любое слово или набор символов {count} раз(а) + ENTER: ");
    inputArray[i] = Console.ReadLine();
}

string PrintArray(string[] array)
{
    string txt = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        txt += $"{array[i]} ";
    }
    return $"[{txt}]";
}
Console.WriteLine($"InputArray = {PrintArray(inputArray)}");

string[] MainTask(string[] inputArray)
{
    string tmp = String.Empty;
    int countOutPutArray = 0;
    int index = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        tmp = inputArray[i];
        if (tmp.Length <= 3)
        {
            countOutPutArray++;
        }
    }

    tmp = String.Empty;
    string[] outputArray = new string[countOutPutArray];

    for (int i = 0; i < inputArray.Length; i++)
    {
        tmp = inputArray[i];
        if (tmp.Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index ++;
        }
    }
    return outputArray;
}
string[] result = MainTask(inputArray);

Console.WriteLine($"Result Array = {PrintArray(result)}");





