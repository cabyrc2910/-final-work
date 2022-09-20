// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых  меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не пользоваться коллекциями, обойтись исключительно массивами.
// Примеры: 
// ["hello","2","World",":-)"]->["2",":-)"]
// ["1234","1567,"-2","computer science"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]

Console.Clear();
string[] str = new string[] { "47", "Пермь", "Петербург", "Волгоград", "777", "Астрахань" };
Console.WriteLine("Исходный массив: "  + string.Join(" ", str));
int count = 0;
for (int i = 0; i < str.Length; i++) 
{
    if (str[i].Length <= 3) count++;
}

int newStrCounter = 0;

string[] newStr = new string[count];
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3) {

        newStr[newStrCounter] = str[i];
        newStrCounter++;

    };
}
Console.Write("Новый массив: ");
for (int i = 0; i < newStr.Length; i++) 
{
    Console.Write(newStr[i] + " ");
}