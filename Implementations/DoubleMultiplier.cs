public class DoubleMultiplier : Multiplier
{
    public override int Multiply(int x, int y)
    {
        // Perform the multiplication and then double the result
        return 2 * (x * y);
    }
}
