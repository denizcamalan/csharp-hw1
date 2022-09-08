internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Please enter exercise number between 1 to 5");
    int exercise;
    if (int.TryParse(Console.ReadLine(), out exercise))
        switch(exercise)
        {
            case 1:
                Ex1.IsPosivesEven();
            break;
            case 2:
                Ex2.IsDivided();
            break;
            case 3:
                Ex3.ReversePrint();
            break;
            case 4:
                Console.WriteLine(Ex4.PrintStringInfo());
            break;
        }

  }
}

public class Ex1
{
    public static void IsPosivesEven()
    {
        List<int> arr = new List<int>();
        int isEven;
        int n;
        Console.WriteLine("Please enter length : ");
        if (int.TryParse(Console.ReadLine(), out n))
            while ( n > 0 )
            {
                if (!int.TryParse(Console.ReadLine(), out isEven) || isEven%2 == 0)
                    arr.Add(isEven);
                n -= 1;
            }
        Console.WriteLine("Even Numbers are : ");
        foreach (int val in arr)
        Console.Write(val+" ");
    }
}

public class Ex2
{
    public static void IsDivided()
    {
         List<int> arr = new List<int>();
        int isDivided;
        int n;
        int m;
        Console.WriteLine("Please enter length : ");
        if (int.TryParse(Console.ReadLine(), out n))
            Console.WriteLine("Please enter divede number : ");
            if (int.TryParse(Console.ReadLine(), out m))
                while (n > 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out isDivided) || isDivided%m == 0)
                        arr.Add(isDivided);
                    n -= 1;
                }
            Console.WriteLine("Even Numbers are : ");
            foreach (int val in arr)
            Console.Write(val+" ");
    }
}

public class Ex3
{
    public static void ReversePrint()
    {
        string[] arr = {};
        string? str;
        int n;
        Console.WriteLine("Please enter length : ");
        if (int.TryParse(Console.ReadLine(), out n))
        {
            arr = new string[n];
            while(n > 0)
            {
                str = Console.ReadLine();
                if (str != null)
                    arr[n-1] = str;    
                n -= 1;
            }
        }
        Console.WriteLine("Even Numbers are : ");
        foreach (string val in arr)
        Console.Write(val+" ");
    }

}

public class Ex4
{
    public static (int,int) PrintStringInfo()
    {
        string[] arr = {};
        string? str;
        int letterCount = 0;
        int wordCount =0;
        Console.WriteLine("Please enter sentence : ");
        str = Console.ReadLine();
        if (!string.IsNullOrEmpty(str))
        {
            foreach (char letter in str)
            {
                if (letter.Equals(' '))
                    wordCount += 1;
            }
            letterCount = str.Count<char>();
        } 
        return (letterCount,wordCount);
    }

}