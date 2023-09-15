using System.Collections;

Console.WriteLine("Hello, World!");

int[] arr = Enumerable.Range(1, 100).ToArray();

for (int i = 0; i < 100; i++)
{
    if ((i % 3) == 0 && (i % 5) != 0)
    {
        Console.WriteLine("Fizz");
    }
    else if ((i % 5) == 0 && (i % 3) != 0)
    {
        Console.WriteLine("Buzz");

    }
    else if ((i % 3) == 0 && (i % 5) == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else
    {
        arr[i] = i;
        Console.WriteLine(arr[i]);
    }
}
