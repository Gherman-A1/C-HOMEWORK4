// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int Prompt(string message)
{
    System.Console.Write(message);
    string value=Console.ReadLine()!;
    int result=Convert.ToInt32(value);
    return result;
}

int GetSum(int number)
{
    int sum=0;

    while(number>0)
    {
       sum=sum+number%10;
       number=number/10;
    }

    return sum;
}

int num=Prompt("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе: {GetSum(num)}");