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
/*   while (index < testcount)
        {
//            bool numberText = true
            if (numberText[index] == numberText[testcount-index])
            {
                index += 1;
                Console.WriteLine("Число является ли оно палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является ли оно палиндромом");
             //   break;
            }
        }
*/}  
else
{
    Console.WriteLine("Это не пятизначное число!");
} 
Console.WriteLine("End");
