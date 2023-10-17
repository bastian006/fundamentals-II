 /*-----------------------------------------------------------------------------------------------*/
static void PrintNumbers()
{
    for (int i = 1; i <= 255; i++)
        {
            Console.WriteLine(i);
        }
}
PrintNumbers();

 /*-----------------------------------------------------------------------------------------------*/
static void PrintOdds()
{
    for (int i = 1; i <= 255; i++)
        {
            if (i % 2 != 0) // Comprueba si el número es impar
            {
                Console.WriteLine(i);
            }
        }
}
PrintOdds();

 /*-----------------------------------------------------------------------------------------------*/
static void PrintSum()
{
   int sum = 0;

        for (int i = 0; i <= 255; i++)
        {
            sum += i;
            Console.WriteLine($"New number: {i} Sum: {sum}");
        }
}
PrintSum();
 /*-----------------------------------------------------------------------------------------------*/
static void LoopArray(int[] numbers)
{
    foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
}
    int[] myArray = { 1, 3, 5, 7, 9 }; // Ejemplo de una matriz de enteros
    LoopArray(myArray);


 /*-----------------------------------------------------------------------------------------------*/
static int FindMax(int[] numbers)
{
    if (numbers.Length == 0)
        {
            throw new InvalidOperationException("La matriz está vacía.");
        }

    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
        {
         if (numbers[i] > max)
            {
                max = numbers[i];
            }
    }

     return max;
}
int[] array3 = { -3, -5, -7 };
        int max1 = FindMax(array3);
        Console.WriteLine("Máximo valor en array1: " + max1);

        int[] array4 = { 1, 5, 10, -2, 0, 7 };
        int max2 = FindMax(array4);
        Console.WriteLine("Máximo valor en array2: " + max2);

 /*-----------------------------------------------------------------------------------------------*/
static void GetAverage(int[] numbers)
{
    if (numbers.Length == 0)
        {
            throw new InvalidOperationException("La matriz está vacía.");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Length;
        Console.WriteLine("Promedio de los valores en la matriz: " + average);
}
    int[] array2 = { 2, 10, 3 };
    GetAverage(array2);

 /*-----------------------------------------------------------------------------------------------*/
static List<int> OddList()
{
   List<int> oddNumbers = new List<int>();
        for (int i = 1; i <= 255; i += 2)
        {
            oddNumbers.Add(i);
        }
        return oddNumbers;
}
 List<int> oddNumbersList = OddList();
        Console.WriteLine("Lista de números impares entre 1 y 255:");
        foreach (int number in oddNumbersList)
        {
            Console.WriteLine(number);
        }

 /*-----------------------------------------------------------------------------------------------*/
static int GreaterThanY(List<int> numbers, int y)
{
        int count = 0;
        foreach (int number in numbers)
        {
            if (number > y)
            {
                count++;
            }
        }
        return count;
}
        List<int> numbersList1 = new List<int> { 1, 3, 5, 7 };
        int y = 3;
        int count = GreaterThanY(numbersList1, y);
        Console.WriteLine($"Número de valores mayores que {y}: {count}");

 /*-----------------------------------------------------------------------------------------------*/
static void EliminateNegatives(List<int> numbers)
{
     for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers[i] = 0;
            }
        }
}

        List<int> numbersList2 = new List<int> { 1, 5, 10, -2 };
        EliminateNegatives(numbersList2);
        Console.WriteLine("Lista después de eliminar los números negativos:");
        foreach (int number in numbersList2)
        {
            Console.WriteLine(number);
        }
