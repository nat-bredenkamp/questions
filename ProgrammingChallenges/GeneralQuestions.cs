namespace ProgrammingChallenges;

public class GeneralQuestions
{
    public void One()
    {
        Console.WriteLine("1. List out the numbers between 1 and 1000 that are dividable by 13 or 17");
        Console.ReadLine();
        
        var multiplesOf13 = GenerateMultiples(13, 1000);
        var multiplesOf17 = GenerateMultiples(17, 1000);
       
        var results = multiplesOf13.AsParallel().Where(x => multiplesOf17.Contains(x));
        // or
        multiplesOf13.IntersectWith(multiplesOf17);
       
        Console.WriteLine(string.Join(Environment.NewLine, results));
        Console.WriteLine(string.Join(Environment.NewLine, multiplesOf13));

        Console.ReadLine();
    }

    public void Two()
    {
        Console.WriteLine("2. List out the first 100 numbers that are dividable by 19");
        Console.ReadLine();
        for (var i = 0; i <= 100; i++)
        {
            Console.WriteLine($"{i * 19}");
        }
        Console.ReadLine();
    }

    public void Three()
    {
        Console.WriteLine("3. List out all the prime numbers between 1 and 1,000,000,000");
        Console.ReadLine();
        var limit = 1000000000;

        OutputPrimes(limit);
        Console.ReadLine();
    }

    public void Four()
    {
        int[] numbers = [1, 12, 34, 19, 27];
        Console.WriteLine(numbers.Sum(x => x * x));
    }

    public void Five()
    {
        var colours = new List<string>(["orange", "yellow", "red", "lilac", "emerald"]);
        colours.Add("crimson");
        colours.Remove("red");
        var colourLetters = colours.Select(x => x.First());
        Console.WriteLine(string.Join(" ", colourLetters));
    }

    public void Six()
    {
        var dictionary = new Dictionary<string, string>
        {
            { "Hungary", "Budapest" },
            { "Germany", "Berlin" },
            { "New Zealand", "Wellington" },
            { "Canada", "Ottawa" },
            { "Slovakia", "Bratislava" },
            { "Croatia", "Zagreb" }
        };
        var capitalsThatStartWithBCount = dictionary.Values.Count(x => x.First() == 'B');
        Console.WriteLine($"{capitalsThatStartWithBCount} capitals start with B");

        if (dictionary.TryAdd("Colombia", "Bogota"))
        {
            Console.WriteLine("Colombia:Bogota added");
            capitalsThatStartWithBCount++;
        }

        Console.WriteLine($"{capitalsThatStartWithBCount} capitals start with B");
    }

    public void Seven()
    {
        Console.WriteLine("Please enter an integer");
        var input = Console.ReadLine();
        if (int.TryParse(input, out var n))
        {
            Console.WriteLine($"would you like to (s)um or (m)ultiply ({n})");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "s":
                    var ans = n * (n + 1) / 2;
                    Console.WriteLine("Sum : " + ans);
                    Console.ReadLine();
                    break;
                
                case "m":
                    if (n > 20)
                    {
                        Console.WriteLine("Anything more than 20 doesnt fit in a long.. :(");
                        Seven();
                    }
                    else
                    {
                        Console.WriteLine(CreateRange(1, n).Aggregate(1, (long p, long item) => p * item));
                        Console.ReadLine();
                    }

                    break;
                
                default:
                    Seven();
                    break;
           }
        }
        else
        {
            Console.WriteLine("Unable to parse your input, please try again");
            Seven();
        }
    }
   
    private static IEnumerable<long> CreateRange(long start, long count)
    {
        var limit = start + count;

        while (start < limit)
        {
            yield return start;
            start++;
        }
    }

    private static HashSet<int> GenerateMultiples(int n, int max)
    {
        var multiples = new HashSet<int>();
        var step = n;
        while (n <= max)
        {
            multiples.Add(n);
            n += step;
        }
        
        return multiples;
    }
    
    /// <summary>
    /// simple sieve that skips all even numbers
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private static void OutputPrimes(int n)
    {
        if (n < 2)
        {
            return;
        }

        var half = (n + 1) / 2;
        var isPrime = new bool[half];
        Array.Fill(isPrime, true);

        var limit = ((int)Math.Sqrt(n) + 1) / 2;
        
        for (var i = 1; i <= limit; i++)
        {
            if (isPrime[i])
            {
                var p = 2 * i + 1;
                for (var j = p * p / 2; j < half; j += p)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (var i = 1; i < half; i++)
        {
            if (isPrime[i])
            {
                var prime = 2 * i + 1;
                Console.WriteLine(prime);
            }
        }
    }
}