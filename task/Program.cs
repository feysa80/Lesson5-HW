// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. ");
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task){
    case 34:
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] myArray = FillArray34(len);
        int count = CheckEvenNumbers(myArray);
        Console.Write("В массиве: ");
        PrintArray(myArray);
        Console.WriteLine($"четных чисел - {count}");
        break;
    case 36:
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int num36 = Convert.ToInt32(Console.ReadLine());
        int[] array36 = FillArray(num36);
        PrintArray(array36);
        Console.WriteLine($"Сумма чисел на нечетных позициях равна - {Task36(array36)}");
        break;
    case 38:
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int num38 = Convert.ToInt32(Console.ReadLine());
        int[] array38 = FillArray(num38);
        PrintArray(array38);
        Console.WriteLine($"разница между максимальным и минимальным числами в массиве равна - {Task38(array38)}");
       
        break;
    default:
        Console.WriteLine("Неправильный ввод номера задачи");
        break;


}

int[] FillArray34(int size){
    int[] array34 = new int [size];
    for(int i = 0; i < size; i++){
        array34[i] = new Random().Next(100,1000);
    }
    return array34;
}

int[] FillArray(int size){
    int[] array = new int [size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(0,100);
    }
    return array;
}

void PrintArray(int[] someArray){

    Console.WriteLine(String.Join(", ", someArray));
}
int CheckEvenNumbers(int[] someArray){
    int result =0;
    int index = 0;
    while(index < someArray.Length){
        if(someArray[index]%2 == 0) result = result + 1;
    index ++;
    }
    return result;
}
int FindMax(int[]someArray){
    int max = someArray[0];
    int index = 1;
    while(index < someArray.Length){
        if(someArray[index] > max) max = someArray[index];
        index++;
    }
    return max;
}
int FindMin(int[]someArray){
    int min = someArray[0];
    int index = 1;
    while(index < someArray.Length){
        if(someArray[index] < min) min = someArray[index];
        index ++;
    }
    return min;
}
 int Task38(int[] someArray){
     int max = FindMax(someArray);
     int min = FindMin(someArray);
     int diff = max - min;
     return diff;
 }



int Task36(int[] someArray){
    int result = 0;
    for(int i =1; i < someArray.Length; i=i+2){
        result = result + someArray[i];
    }
    return result;
}