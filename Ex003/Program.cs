// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Создай таблицу кубов от 1 до ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;
int[] array = new int[count];
int i = 0;
array[i] = 1;

while (i < count)
{
    int numberCube = array[i] * array[i] * array[i];
    Console.Write(numberCube + " ");
    if ((i + 1) < count)
        {
            array[i + 1] = array[i] + 1;
        }
    i++;
}
Console.WriteLine();
Console.WriteLine("end");
