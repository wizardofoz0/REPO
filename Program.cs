int GetM (string [] Old, int max)
{
    int j = 0;
    for (int i = 0; i<Old.Length; i++)
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
string [] c ={"1234", "1567", "-2", "computer science"}; 
string [] d ={"Russia", "Denmark", "Kazan"};
int StringLenght = 3;
Console.WriteLine("Заданный массив");
PrintArray(a);
Console.WriteLine(" ");
Console.WriteLine("Полученный массив");
string [] b = GetNewArray(a, StringLenght, GetM(a, StringLenght));
PrintArray(b);
Console.WriteLine(" ");