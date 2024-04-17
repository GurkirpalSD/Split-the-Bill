
namespace SplitAmountLibrary
{
    public class SplitAmount
    {
        public static decimal Split(decimal amount, int numPeople)
        {
            if (numPeople <= 0 || amount < 0)
            {
                return 0;
            }
            return amount / numPeople;
        }
    }
}