Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
if (B >= 1)
{
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Второе число - не натуральное");
};