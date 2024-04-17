
namespace SplitAmountLibrary
{
    public class CalculateTipForDictionary
    {
        public static Dictionary<string, decimal> Calculate(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            if (tipPercentage < 0 || tipPercentage > 100)
            {
                throw new ArgumentException("Tip percentage must be between 0 and 100.");
            }

            decimal totalCost = 0;
            foreach (var cost in mealCosts.Values)
            {
                totalCost += cost;
            }

            Dictionary<string, decimal> tipAmounts = new Dictionary<string, decimal>();
            foreach (var entry in mealCosts)
            {
                decimal tip = entry.Value / totalCost * (decimal)tipPercentage / 100.0M;
                tipAmounts.Add(entry.Key, tip);
            }

            return tipAmounts;
        }
    }
}