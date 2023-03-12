Console.WriteLine("Задай размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
double min = Int32.MaxValue;//Int32
double max = Int32.MinValue;
randomNumbers(numbers);
Console.WriteLine("Полученные числа: ");
printArray(numbers);

for (int j = 0; j < numbers.Length; j++)
{
 if (numbers[j] > max)
  { max = numbers[j]; }
 if (numbers[j] < min)
  { min = numbers[j]; }
}

void randomNumbers(double[] numbers)
{
  for(int i = 0; i < numbers.Length; i++)
 {
    numbers[i] = Convert.ToDouble(new Random().Next(0,100)) / 100; // 0-100/100 = 0,*
 }
}

void printArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
 { 
    Console.Write(numbers[i] + " ");
 }
}

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива: {max - min}");