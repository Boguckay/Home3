//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

//Console.Write("Введите число: ");
//string? number = Console.ReadLine();

//void CheckingNumber(string number){
  //if (number[0]==number[4] || number[1]==number[3]){
    //Console.WriteLine($"Ваше число: {number} - палиндром.");
  //}
  //else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
//}

//if (number!.Length == 5){
  //CheckingNumber(number);
//}
//else Console.WriteLine($"Введи правильное число");



Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrom()
{
    int num1 = number % 10;
    int num2 = number % 100 / 10;
    int num3 = number % 1000 / 100;
    int num4 = number % 10000 / 1000;
    int num5 = number / 10000;

    return (num1 == num5 && num2 == num4);

}
Console.WriteLine(Palindrom() ? "Данное число палиндромом" : "Число не является палиндромом");

//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

//Console.WriteLine("Введите значение x1: ");
//var x1 = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Введите значение y1: ");
//var y1 = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Введите значение z1: ");
//var z1 = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Введите значение x2: ");
//var x2 = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Введите значение y2: ");
//var y2 = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Введите значение z2: ");
//var z2 = Convert.ToInt16(Console.ReadLine());

//var result = Math.Sqrt((Math.Pow((x1 - x2),2)) + (Math.Pow((y1 - y2),2)) + (Math.Pow((z1 - z2),2)));

   
//Console.WriteLine(result);



//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//Console.Write("Введите число: ");
//var num = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= num; i++)//
//{
  //    Console.WriteLine(Math.Pow(i, 3));
  //}
