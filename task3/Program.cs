/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите день недели: ");
int numbersWeek = int.Parse(Console.ReadLine());

if ((numbersWeek == 6) | (numbersWeek == 7)){
    Console.Write("Выходной");
} else {
    Console.Write("Будни");
}
