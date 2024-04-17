
namespace SplitAmountLibrary
{
    public class SplitAmount
    {
        public static decimal Split(decimal amount, int numPeople)
        {
            if (numPeople <= 0)
            {
                throw new ArgumentException("Number of people must be greater than zero.");
            }
            return amount / numPeople;
        }
    }
}