Console.Write("Введите с клавиатуры M чисел через пробел:");
string[] str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"{String.Join(",", str)}->{bol(str)}");

int bol(string[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int per = int.Parse(array[i]);
        if ( per > 0)
        {
            count++;
        }
    }
    return count;
}