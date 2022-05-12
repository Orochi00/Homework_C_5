void print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] mass = new int[4];
print(mass);

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-99, 99);
}
print(mass);
var even = mass.Where((element, index) => index % 2 != 0);
Console.WriteLine("Сумма на четных позициях: {1}.", even.Count(), even.Sum());