

namespace SplitAmountLibrary
{
    public class CalculateTipPerPerson
    {
        public static decimal Calculate(decimal totalPrice, int numPatrons, float tipPercentage)
        {
            if (numPatrons <= 0)
            {
                throw new ArgumentException("Number of patrons must be greater than zero.");
            }

            decimal tipAmount = totalPrice * (decimal)(tipPercentage / 100.0f);
            decimal tipPerPerson = tipAmount / numPatrons;

            return tipPerPerson;
        }

        public static implicit operator decimal(CalculateTipPerPerson v)
        {
            throw new NotImplementedException();
        }
    }
}