// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Задайте размер массива");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];

for (int i = 0; i<kol; i++)
{
    Console.WriteLine("Введите число");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArr();
SravnArr();
void PrintArr()
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < kol; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine(" ");
}

void SravnArr()
{
    int count = 0;
    for (int i = 0; i<kol; i++)
    {
        if (array[i]>0) {count++;}
    }
Console.WriteLine("Количество положительных чисел в массиве = " + count);
}
