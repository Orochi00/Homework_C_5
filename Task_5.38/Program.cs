    int[] array = new int[5];
    
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = rand.Next()%100-50;
    }
    
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    
    int imin = 0, imax = 0;
    
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > array[imax])
            imax = i;
        if (array[i] < array[imin])
            imin = i;
    }
    Console.WriteLine("min = " + array[imin]);
    Console.WriteLine("max = " + array[imax]);
    
    int prod = array[imax] - array[imin];
    Console.WriteLine("разница между ними " + prod);