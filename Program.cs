// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] CreateArray(int lengthArray, double start, double finish){
    double[] array = new double[lengthArray];
    for(int i=0; i<lengthArray;i++){
        Random random = new Random();
        array[i] =start+random.NextDouble()*(finish-start);
    }
return array;
}


void PrintArray(double[] array){
    Console.Write("[");
    for(int i=0;i<array.Length;i++){
        if(i!=array.Length-1)
            Console.Write($"{array[i].ToString("F2")}; ");
        else
            Console.WriteLine($"{array[i].ToString("F2")}]");
    }
}

double SearchForMax(double[] array){
    double max = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if(max < array[index]){
            max = array[index];
        }
    }
    return max;
}

double SearchForMin(double[] array){
    double min = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if(min > array[index]){
            min = array[index];
        }
    }
    return min;
}

Console.Write("Введите длину массива N=");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапозона start=");
double start = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите окончание диапазона finish=");
double finish = Convert.ToDouble(Console.ReadLine());
if (finish<start) {
    double temp = finish;
    finish = start;
    start = temp;
}


double[] arr = CreateArray(lengthArr,start,finish);
PrintArray(arr);
Console.WriteLine($"max - min = {(SearchForMax(arr)-SearchForMin(arr)).ToString("F2")}");


