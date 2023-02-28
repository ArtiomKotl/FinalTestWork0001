// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void PrintArray(string[] printArray)
{
  Console.Write("[");
  for (int i = 0; i < printArray.Length; i++)
  {
    if (i == printArray.Length - 1)
      Console.Write($"\"{printArray[i]}\"");
    else
      Console.Write($"\"{printArray[i]}\", ");
  }
  Console.WriteLine("]");
}

string[] UserInputArray(int num)
{
  string[] array = new string[num];
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Введите строку № {i}: ");
    array[i] = Console.ReadLine()!;
  }
  return array;
}

string[] FillArray(string[] userArray)
{
  int count = 0;
  for (int i = 0; i < userArray.Length; i++)
  {
    if (userArray[i].Length <= 3)
      count++;
  }
  string[] newArray = new string[count];
  count = 0;
  for (int i = 0; i < userArray.Length; i++)
  {
    if (userArray[i].Length <= 3)
    {
      newArray[count] = userArray[i];
      count++;
    }
  }
  return newArray;
}

Console.Write("Ведите количество строк массива >>: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
  Console.WriteLine("Число меньше 1! попробуйте ещё: ");
  int.TryParse(Console.ReadLine(), out num);
}

string[] userArray = UserInputArray(num);
string[] FinalArray = FillArray(userArray);

Console.WriteLine("Введённый массив строк:");
PrintArray(userArray);
Console.WriteLine("Полученный массив строк:");
PrintArray(FinalArray);