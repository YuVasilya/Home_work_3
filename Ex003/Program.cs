// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Создай таблицу кубов");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;
int[] array = new int[count];
int i = 0;
array[i] = 1;

while (i < count)
{
    int numberCube = array[i] * array[i] * array[i];
    Console.Write(numberCube + " ");
    array[i + 1] = array[i] + 1;
    i ++;
}
Console.WriteLine("end");
