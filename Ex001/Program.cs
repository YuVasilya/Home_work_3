// Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Напишите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
int count = 5;
int index = 0;

if (numberText.Length == count)
{
    int testcount = (count / 2);
   if (index < testcount)
        {
            if (numberText[index] == numberText[count - 1 -index])
            {
                index += 1;
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
            index += 1;
        }
}  
else
{
    Console.WriteLine("Это не пятизначное число!");
} 
Console.WriteLine("End");
