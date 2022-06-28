/*int n;
int x;
Console.WriteLine("Input a n");
n=Convert.ToInt32(Console.ReadLine());
x=1;

if (n<=1)
{
    Console.WriteLine("Are you crazy?");
}
while (x<=n)
{
    if (x%2==0)
    Console.WriteLine(x+ "");
    x++; 
}*/

int num;
Console.WriteLine("Input a num: ");
num=Convert.ToInt32(Console.ReadLine());
if (num%2==0)
{
    Console.WriteLine("Чётное");
    }
    else
    {
    Console.WriteLine("Нечетное");
    }