class Program
{
    static void Main(string[] args)
    {
        // Initialize instances of each multiplier
        SimpleMultiplier simpleMultiplier = new SimpleMultiplier();
        DoubleMultiplier doubleMultiplier = new DoubleMultiplier();
        TripleMultiplier tripleMultiplier = new TripleMultiplier();
        NegativeMultiplier negativeMultiplier = new NegativeMultiplier();
        ZeroMultiplier zeroMultiplier = new ZeroMultiplier();
        IncrementMultiplier incrementMultiplier = new IncrementMultiplier();

        // Store multiplication results
        int simpleResult = simpleMultiplier.Multiply(5, 3);
        int doubleResult = doubleMultiplier.Multiply(5, 3);
        int tripleResult = tripleMultiplier.Multiply(5, 3);
        int negativeResult = negativeMultiplier.Multiply(5, 3);
        int zeroResult = zeroMultiplier.Multiply(5, 3);
        int incrementResult = incrementMultiplier.Multiply(5, 3);

        // Output results
        Console.WriteLine($"Simple multiplication result: {simpleResult}");
        Console.WriteLine($"Doubled multiplication result: {doubleResult}");
        Console.WriteLine($"Tripled multiplication result: {tripleResult}");
        Console.WriteLine($"Negated multiplication result: {negativeResult}");
        Console.WriteLine($"Zero multiplication result: {zeroResult}");
        Console.WriteLine($"Incremented multiplication result: {incrementResult}");
    }
}
