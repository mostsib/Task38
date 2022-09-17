// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] myArray = new double[5];

 Random rand = new Random();
            
         for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(-100, 100);
                Console.WriteLine("Значение элемента массива " + i + " = " + myArray[i]);
            }
        Console.WriteLine("Минимальное число: " + myArray.Min());
        Console.WriteLine("Максимальное число: " + myArray.Max());

double razn = (myArray.Max()+(myArray.Min()));
Console.WriteLine("Разность максимального и минимального чисел:  " + razn);