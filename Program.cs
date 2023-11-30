// Задание 1
// Задайте одномерный массив из 10 целых 
// чисел от 1 до 100. Найдите количество элементов 
// массива, значения которых лежат в отрезке [20,90].

// Console.Write("Введите количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = new int[size];
// Random r = new Random();

// for(int i = 0; i < size; i++)
// {
//    myArray[i] = r.Next(100);
// }

// int count = 0;
// for(int i = 0; i < size; i++)
// {
//    Console.Write(myArray[i] + " ");
//    if (myArray[i] > 20 && myArray[i] < 90)
// {
//     count++;
// }
// }
// System.Console.WriteLine($"=> " + count);

// Задание 2
// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет 
// количество чётных чисел в массиве.

//Console.Write("Введите количество элементов в массиве: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] myArray = new int[size];
//Random r = new Random();
//
//for(int i = 0; i < size; i++)
//{
//    myArray[i] = r.Next(100);
//}
//
//int count = 0;
//for(int i = 0; i < size; i++)
//{
//   Console.Write(myArray[i] + " ");
//   if (myArray[i] % 2 == 0)
//{
//    count++;
//}
//}
// System.Console.WriteLine($"=> " + count);

// Задание 3
//Задайте массив из вещественных чисел с 
//ненулевой дробной частью. Найдите разницу между 
//максимальным и минимальным элементов массива.

//Console.Write("Введите количество элементов в массиве: ");
//int size = Convert.ToInt32(Console.ReadLine());
Random r = new Random();
double d = Math.Round(r.Next(100) + r.NextDouble(), 2);

double[] myArray = new double[10];

for(int i = 0; i < 10; i++)
{
    myArray[i] = Math.Round(r.Next(10) + r.NextDouble(), 2);
}

for(int i = 0; i < 10; i++)
{
    System.Console.Write(myArray[i] + " | "); 
}

double max = myArray[0];
double min = myArray[0];

for(int i = 0; i < 10; i++)
{
   if (myArray[i] > max)
   {
    max = myArray[i];
   }
   else if (myArray[i] < min)
   {
    min = myArray[i];
   }
}
double diff = Math.Round(max - min, 2);

System.Console.WriteLine(" ");
System.Console.WriteLine("Max =" + max);
System.Console.WriteLine("Min = " + min);
System.Console.WriteLine("Разница между максимальным и минимальным значением = " + diff);