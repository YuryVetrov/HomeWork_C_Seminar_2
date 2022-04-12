// Напишите программу, которая принимает на вход три числа и выдает, 
// максимальное из этих чисел
// 1) 2,3,7 -> 7
// 2) 44, 5, 78 -> 78
// 3) 22, 3, 9 -> 22
int numberA, numberB, numberC;
int max;

numberA = 22;
numberB = 3;
numberC = 9;

max = numberA;

if (numberB > max)
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

 System.Console.WriteLine(max);




     
 


