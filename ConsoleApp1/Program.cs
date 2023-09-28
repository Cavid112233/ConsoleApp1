namespace ConsoleApp1
{
    internal class Program
    {
        #region Task1
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Eded daxil edin: ");
        //    int eded = int.Parse(Console.ReadLine());

        //    if (IsPowerOfTwo(eded))
        //    {
        //        Console.WriteLine($"{eded} 2 qüvvetidir.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{eded} 2 qüvveti deyil.");
        //    }
        //}
        //static bool IsPowerOfTwo(int number)
        //{
        //    if (number == 0)
        //    {
        //        return false;
        //    }
        //    return (number & (number - 1)) == 0;
        //}
        #endregion
        #region Task2
        //static void Main()
        //{
        //    Console.WriteLine("n daxil edin: ");
        //    int n = int.Parse(Console.ReadLine());

        //    int digitCount = CountDigitsFrom1ToN(n);

        //    Console.WriteLine($"1-den {n}-e qeder olan ededler arasinda {digitCount} reqem var.");
        //}

        //static int CountDigitsFrom1ToN(int n)
        //{
        //    int digitCount = 0;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        digitCount += CountDigits(i);
        //    }

        //    return digitCount;
        //}

        //static int CountDigits(int number)
        //{
        //    int digitCount = 0;

        //    while (number > 0)
        //    {
        //        digitCount++;
        //        number /= 10;
        //    }

        //    return digitCount;
        //}
        #endregion
        #region Task3
        //static void Main()
        //{
        //    Console.WriteLine("eded daxil edin: ");
        //    int eded = int.Parse(Console.ReadLine());

        //    bool mukemmelMi = IsPerfectNumber(eded);

        //    Console.WriteLine($"Mukemmel eded: {mukemmelMi}");
        //}

        //static bool IsPerfectNumber(int number)
        //{
        //    if (number <= 1)
        //    {
        //        return false;
        //    }

        //    int toplam = 1;

        //    for (int i = 2; i * i <= number; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            toplam += i;
        //            if (i != number / i)
        //            {
        //                toplam += number / i;
        //            }
        //        }
        //    }

        //    return toplam == number;
        //}
        #endregion
        #region Task4
        //static void Main()
        //{
        //    Console.Write("N ededini daxil edin: ");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    string binary = DecimalToBinary(n);

        //    Console.WriteLine($"N ededi ikilik say sisteminde: {binary}");
        //}

        //static string DecimalToBinary(int decimalNumber)
        //{
        //    if (decimalNumber == 0)
        //    {
        //        return "0";
        //    }

        //    string binary = "";

        //    while (decimalNumber > 0)
        //    {
        //        int remainder = decimalNumber % 2;
        //        binary = remainder + binary;
        //        decimalNumber /= 2;
        //    }

        //    return binary;
        //}
        #endregion
        #region Task5
        static void Main()
        {
            Console.Write("Bir ədəd daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int largestDigit = FindLargestDigit(n);
            int smallestDigit = FindSmallestDigit(n);

            int result = largestDigit * smallestDigit;

            Console.WriteLine($"En böyük reqem: {largestDigit}");
            Console.WriteLine($"En kiçik reqem: {smallestDigit}");
            Console.WriteLine($"En böyük ve en kiçik reqemlerin hasilesi: {result}");
        }

        static int FindLargestDigit(int number)
        {
            int largestDigit = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit > largestDigit)
                {
                    largestDigit = digit;
                }
                number /= 10;
            }
            return largestDigit;
        }

        static int FindSmallestDigit(int number)
        {
            int smallestDigit = 9;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit < smallestDigit)
                {
                    smallestDigit = digit;
                }
                number /= 10;
            }
            return smallestDigit;
        }
        #endregion
    }
}