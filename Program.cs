using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Qiymet(30,40,60,80,90,100));
       // Caculator(12,13, '+');
        // Console.WriteLine(asa("yusif", "quluzade", "elsen",'a')); 
        //Console.WriteLine(value(12,13,14,15,1));
        //Console.WriteLine(reqem(2,5)); ;

        //Console.WriteLine(FindCharIndex("alnur", 'l'));
    }
    //static int FindCharIndex(string  ad,char vlaue)
    //{
    //    for(int i = 0; i < ad.Length; i++)
    //    {
    //        if (ad[i] == vlaue)
    //        {

    //        return i++; 
    //        }
    //    }
    //    return -1;
    //}

    //static int reqem(int num)
    //{
    //    return num * num;
    //}

    //static int reqem(int num1, int num2)
    //{
    //    int deyisen = 1;
    //    for (int i = 0; i < num2; i++)
    //    {

    //        deyisen *= num1;

    //    }
    //    return deyisen;
    //}
    //static bool value(params  int[] numbers)
    //{
    //    for(int i = 0; i < numbers.Length; i++)
    //    {
    //        for(int j = 0; j <numbers.Length ; j++)
    //        {

    //        if (numbers[i] > numbers[j])
    //        {
    //                return true;
    //        }
    //        }   
    //    } 
    //    return false;
    //}
    //static string asa(string ad, string soyad)
    //{
    //    return soyad;
    //}
    //static string asa(string name,string surname,string ata,char a)
    //{
    //    return 
    //}

    //static void Caculator(int num1, int num2, char op)
    //{
    //    switch (op)
    //    {
    //        case '+':
    //            Console.WriteLine(num1 + num2);

    //            break;
    //        case '-':
    //            Console.WriteLine(num1 - num2);
    //            break;
    //        case '*':
    //            Console.WriteLine(num1 * num2);
    //            break;
    //        case '/':
    //            Console.WriteLine(num1 / num2);
    //            break;

    //    }

    //}
    //static int Qiymet(int num1, int num2, int num3, int num4, int num5, int num6) 
    //{
    //    int netice = (num1 + num2 + num3 + num4 + num5 + num6) / 6;
    //    if (netice > 60)
    //    {
    //        Console.WriteLine("mezunoldunuz");
    //    }
    //    else {
    //        Console.WriteLine("kesildiniz");
    //    }
    //    return (num1 + num2 + num3 + num4 + num5 + num6)/6;
    //}
}