// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Дополнительная задача (задача со звёздочкой): Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.
// [1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
// [2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
// [1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами
// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Задайте одномерный массив из N элементов, заполненный случайными числами. Необходимо определить, в какой последовательности заданы элементы массива: по возрастанию, по убыванию, хаотично, или все элементы одинаковы.
// [1,2,3,4] -> по возрастанию
// [4,3,2,1] -> по убыванию
// [4,2,3,1] -> хаотично
// [1,1,1,1] -> все элементы равны


Console.Clear();
Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. ");
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("Задача1 (задача со звёздочкой): Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.");
Console.WriteLine("Задача 2 (задача со звёздочкой): Задайте одномерный массив из N элементов, заполненный случайными числами. Необходимо определить, в какой последовательности заданы элементы массива: по возрастанию, по убыванию, хаотично, или все элементы одинаковы.");
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());
switch (task){
    case 34:
        int[] myArray = BeginTask();
        int count = CheckEvenNumbers(myArray);
        Console.Write("В массиве: ");
        PrintArray(myArray);
        Console.WriteLine($"четных чисел - {count}");
        break;
    case 36:
        int[] array36 = BeginTask();
        PrintArray(array36);
        Console.WriteLine($"Сумма чисел на нечетных позициях равна - {Task36(array36)}");
        break;
    case 38:
        int[] array38 = BeginTask();
        PrintArray(array38);
        Console.WriteLine($"разница между максимальным и минимальным числами в массиве равна - {Task38(array38)}");
        break;
    case 1:
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Task1(num1);
        break;
    case 2:
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Task2(num2); //в task2 есть закоментированные массивы для проверки
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
int[] BeginTask(){
    Console.Clear();
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] someArray = FillArray(size);
    return someArray;
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
int[] FillArrayEven(int[] someArray){
    int index = 0;
    int count = 0;
        while(index < someArray.Length){
        if(someArray[index]%2 == 0) count = count + 1;
    index ++;
    }
    index = 0;
    int[] newArray = new int[count];
    for (int i = 0; i < someArray.Length; i++){
        if(someArray[i]%2 == 0) {
            newArray[index] = someArray[i];
            index++;
        }
    }
    return newArray;
}
int[] FillArrayOdd(int[] someArray){
    int index = 0;
    int count = 0;
        while(index < someArray.Length){
        if(someArray[index]%2 > 0) count = count + 1;
    index ++;
    }
    index = 0;
    int[] newArray = new int[count];
    for (int i = 0; i < someArray.Length; i++){
        if(someArray[i]%2 > 0) {
            newArray[index] = someArray[i];
            index++;
        }
    }
    return newArray;
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
double FindAverage(int[] someArray){
    int sum = someArray[0];
    for(int i = 1; i < someArray.Length; i++){
       sum = sum + someArray[i];
    }
    double average = sum / someArray.Length;
    return average;
}
int CheckArray(int[]someArray){
    int count = 0;
    for(int i = 1; i < someArray.Length; i++){
        if(someArray[i] > someArray[i-1]) count++;
        else if(someArray[i] < someArray[i-1]) count--;
        else if(someArray[i] == someArray[i-1]) count= count + 2;
    }
    return count;
}
void Task2(int num){
    //int[] someArray = {6,5,4,3,2}; 
    //int[] someArray = {1,2,3,4,5,6};
    //int[] someArray = {1,1,1,1,1};
    int[] someArray = FillArray(num);
    PrintArray(someArray);
    int result = CheckArray(someArray);
    int size = someArray.Length -1;
    if(result == size ) Console.WriteLine("По возрастанию");
    else if(result == -size) Console.WriteLine("По убыванию");
    else if(result == size*2) Console.WriteLine("Все элементы равны");
    else Console.WriteLine("Хаотично");
       
}
 int Task38(int[] someArray){
     int max = FindMax(someArray);
     int min = FindMin(someArray);
     int diff = max - min;
     return diff;
 }
void Task1(int number){
        int[] array1 = FillArray(number);
        int[] array11 = FillArrayEven(array1);
        int[] array12 = FillArrayOdd(array1);
        Console.Write("Исходный массив: ");
        PrintArray(array1);
        Console.Write("Получившийся массив из четных чисел: ");
        PrintArray(array11);
        Console.Write("Получившийся массив из нечетных чисел: ");
        PrintArray(array12);
        double averEven = FindAverage(array1);
        double averOdd = FindAverage(array12);
       if(averEven > averOdd){
        Console.WriteLine($"средн. арифм. значений элементов массива с чётными числами {averEven} > средн. арифм. значений элементов с нечётными числами {averOdd}");
       } else if (averEven < averOdd){
        Console.WriteLine($"средн. арифм. значений элементов массива с чётными числами {averEven} < средн. арифм. значений элементов с нечётными числами {averOdd}");
       } else if (averEven == averOdd){
        Console.WriteLine($"средн. арифм. значений элементов массива с чётными числами {averEven} = средн. арифм. значений элементов с нечётными числами {averOdd}");
       } else {
        Console.WriteLine("Ошибка");
       }


}
int Task36(int[] someArray){
    int result = 0;
    for(int i =1; i < someArray.Length; i=i+2){
        result = result + someArray[i];
    }
    return result;
}
