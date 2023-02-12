// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] inputArray;
Console.WriteLine("Введите массив строк через пробел ");
string inputString = Console.ReadLine();
inputArray = inputString.Split(' ');
int count = 0;
string outputString = string.Empty;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        count++;
        outputString = outputString + inputArray[i] + ";";
    }
}
string[] resultArray = new string[count];
resultArray = outputString.Split(';');
Console.WriteLine("Массив из строк длинной до 3 символов: " + string.Join(" ", resultArray));