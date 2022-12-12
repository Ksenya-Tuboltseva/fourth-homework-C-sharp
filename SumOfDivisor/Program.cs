Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sizeOfNumber = 0; //Количество цифр числа
int CopyOfNumber = number; //копия изначального числа number
while(CopyOfNumber > 0)
{
    CopyOfNumber = CopyOfNumber / 10;
    sizeOfNumber++;
}

int CopyOfNumber2 = number; //копия изначального числа number
int [] arrayWithNumber = new int [sizeOfNumber]; //массив с длинной введенного числа
for(int i = 0; i < sizeOfNumber; i++)
{
    arrayWithNumber[i] = CopyOfNumber2 % 10;
    CopyOfNumber2 = CopyOfNumber2 / 10;
}

int sum = 0;  //сумма делителей
for(int i = 0; i < sizeOfNumber; i++)
{
    if (arrayWithNumber[i] > 0)
    {
        if (number % arrayWithNumber[i] == 0)
        {
            sum = sum + arrayWithNumber[i];
        };
    };
};
Console.WriteLine(sum);