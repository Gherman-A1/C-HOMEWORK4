// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int Prompt(string message)
{
    System.Console.Write(message);
    string value=Console.ReadLine()!;
    int result=Convert.ToInt32(value);
    return result;
}

int GetMathPower(int numberA,int numberB)
{
    int power=1;

    for(int i=0; i<numberB; i++)
    {
     power=power*numberA;
    }

    return power;
}

int numA=Prompt("Введите первое число: ");
int numB=Prompt("Введите второе число: ");
Console.WriteLine($"Степень : {GetMathPower(numA, numB)}");