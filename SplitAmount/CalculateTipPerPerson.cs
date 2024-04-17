

namespace SplitAmountLibrary
{
   public class CalculateTipPerPerson
    {
        public static decimal Calculate(decimal totalPrice, int numPatrons, float tipPercentage)
        {
            if (numPatrons <= 0 || tipPercentage < 0 || tipPercentage > 100)
            {
                return 0; 
            }

            decimal tipAmount = totalPrice * (decimal)(tipPercentage / 100.0f);
            decimal tipPerPerson = tipAmount / numPatrons;

            return tipPerPerson;
        }
    }
}