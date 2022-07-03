// выяснить является ли число четным
Console.WriteLine("введите число ");
int a=int.Parse(Console.ReadLine());
int b=2;
if(a % b==1)
{
Console.WriteLine("является нечетным числом ");
Console.Write(a);
}
else
{
Console.WriteLine("является четным числом ");
Console.Write(a);
}