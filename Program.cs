string[] GetNewArray (string [] Old, int max)
{
    string [] New = new string [Old.Length];
    int j = 0;
    for (int i = 0; i<Old.Length; i++)
    {
     if (Old[i].Length <= max)
        {
        New[j] = Old[i];
        j ++;
        }
    }
    int M = j;
    return New;
}


void PrintArray (string [] Strings)
{
    for (int i = 0; i<Strings.Length; i++)
    {
     if (Strings[i] is not null) /*печатаются только заполненные элементы*/
     {Console.Write(Strings[i]);
     Console.Write(" | ");}
    }
}


string [] a = {"Hello", "2", "world", ":-)"};
Console.WriteLine("Заданный массив");
PrintArray(a);
Console.WriteLine(" ");
Console.WriteLine("Полученный массив");
string [] b = GetNewArray(a, 3);
PrintArray(b);
Console.WriteLine(" ");