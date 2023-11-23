using System.Data;
using System.Runtime.Intrinsics.Arm;

namespace Console1;
class Program
{
    static void Main(string[] args)
    {
        //Task 1

        string a = "2222";
        Console.WriteLine("7" + a + "8");

        //Task 2

        string b = "333";
        Console.WriteLine(b + b);

        //Task 3

        int c = 12345;

        int percentage_18 = (c * 18) / 100;
        int percentage_3 = (c * 3) / 100;
        Console.WriteLine(percentage_18 + "," + percentage_3);


        //Task 4

        int d = 345;
        int d_7 = (d * 10) + 7;
        int percentageof_7 = (d_7 * 7) / 100;
        Console.WriteLine(percentageof_7);

        //Task 5

        int number = 1111;
        number = number + 40000;
        number = (number * 100) + 44;
        number = (number * 44) / 100;
        Console.WriteLine(number);

        //Task 6

        int number_tsk6 = 7777;
        int sqr = 2;
        number_tsk6 = (number_tsk6 * 20) / 100;
        number_tsk6 = (number_tsk6 * 10) / 100;
        number_tsk6 = (int)Math.Pow(number_tsk6, sqr);
        Console.WriteLine(number_tsk6);

        //Task 7

        int sayi1 = 12345;
        int sayi2 = 56308;
        int toplam = sayi1 + sayi2;
        int yeniSayi = Convert.ToInt32("5" + toplam + "5");
        double sonuc = (yeniSayi * 5) / 100;
        Console.WriteLine(sonuc);

        //Task 8

        int num1 = 5565;
        int num2 = 7162148;

        num1 = (num1 * 4) / 100;
        num2 = (num2 * 9) / 100;

        double sum = num1 + num2;

        sum = (sum * 10) / 100;

        Console.WriteLine(sum);

        //Task 9

        int n1 = 123456;
        int n2 = 654321;
        int n3 = 590438;

        n1 = (n1 * 10) / 100;
        n2 = (n2 * 10) / 100;
        n3 = (n3 * 10) / 100;

        int sumof = n1 + n2 + n3;

        sumof = (sumof * 10) / 100;

        Console.WriteLine(sumof);

        //Task 10

        int eded1 = 2345;
        int eded2 = 7896;
        int eded3 = 5792;

        eded1 = (eded1 * 1) / 100;
        eded2 = (eded2 * 2) / 100;
        eded3 = (eded3 * 3) / 100;

        int dif = eded1 - eded2 - eded3;

        eded3 = (eded3 * 7) / 100;

        int sumofdif = dif + eded3;
        Console.WriteLine(sumofdif);



    }
}
