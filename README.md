# Итоги блока. Выбор специализации. IT-специалист
## Урок 6. Продакт-менеджер
### Итоговая проверочная работа

Данный репозиториий решает ~~одну~~ задачу на C#.

**_Задача:_** Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*
1. [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
2. [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
3. [“Russia”, “Denmark”, “Kazan”] → []

### Блок-схема

![Блок-схема алгоритма](/Algorithm.png "Блок-схема алгоритма")

### Листинг кода

int GetM (string [] Old, int max)
{
    int j = 0;
    for (int i = 0; i < Old.Length; i++)
    {
     if (Old[i].Length <= max)
        {
        j ++;
        }
    }
    int M = j;
    return M;
     

}

string[] GetNewArray (string [] Old, int max, int M)
{
    string [] New = new string [M];
    int j = 0;
    for (int i = 0; i<Old.Length; i++)
    {
     if (Old[i].Length <= max)
        {
        New[j] = Old[i];
        j++;
        }
    }
    return New;
}


void PrintArray (string [] Strings)
{
    for (int i = 0; i<Strings.Length; i++)
    {
     Console.Write(Strings[i]);
     Console.Write(" | ");
    }
}


string [] a = {"Hello", "2", "world", ":-)"};
int StringLenght = 3;
Console.WriteLine("Заданный массив");
PrintArray(a);
Console.WriteLine(" ");
Console.WriteLine("Полученный массив");
string [] b = GetNewArray(a, StringLenght, GetM(a, StringLenght));
PrintArray(b);
Console.WriteLine(" ");