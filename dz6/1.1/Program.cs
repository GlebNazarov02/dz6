void KolichestvoNuley(int[] arr)
{
    int count = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            {
                count++;
            }
    }
    Console.WriteLine($"Кол-во элементов > 0: {count}");
}

Console.Write("Введите элементы(через пробел): "); 
int[] strocks = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
KolichestvoNuley(strocks);