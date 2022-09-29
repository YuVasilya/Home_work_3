// Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Найдём расстояние между двумя точками в 3D пространстве");
int count = 3;
int [] vec1 = new int [count];

for (int i = 0; i<count; i++)
{
    vec1[i] = new Random().Next(-10, 10);   
}
Console.Write("Первая точка: ");
Console.Write("(");
for (int i = 0; i<count; i++)
{
    Console.Write(vec1[i] + ", ");
}
Console.WriteLine(")");

int [] vec2 = new int [count];

for (int i = 0; i<count; i++)
{
    vec2[i] = new Random().Next(-10, 10);   
}
Console.Write("Вторая точка: ");
Console.Write("(");
for (int i = 0; i<count; i++)
{
    Console.Write(vec2[i] + ", ");
}
Console.WriteLine(")");

Console.Write("Расстояние между точками: ");
double sum = 0;
for (int i = 0; i<count; i++)
{
    sum = sum + (vec2[i]-vec1[i])*(vec2[i]-vec1[i]);
}

double distance = Math.Sqrt(sum);
Console.WriteLine(distance);
Console.WriteLine("End");