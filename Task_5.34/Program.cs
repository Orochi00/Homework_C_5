
int[,] arr = new int[1,4];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
        arr[i, j] = rnd.Next(100, 999);
for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0,5}", arr[i, j]);
int even;
even = 0;
for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
        if (arr[i, j] % 2 == 0)
            even++;
Console.WriteLine($"Количество четных: {even}");
