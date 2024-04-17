

using SplitAmountLibrary;


namespace SplitAmountTest
{
    [TestClass]
    public class SplitAmountTests
    {
        [TestMethod]
        public void Split_ValidInput_ReturnsCorrectAmount()
        {
            // Arrange
            decimal amount = 150.0M;
            int numPeople = 5;
            decimal expectedSplit = 30.0M;

            // Act
            decimal actualSplit = SplitAmount.Split(amount, numPeople);

            // Assert
            Assert.AreEqual(expectedSplit, actualSplit);
        }
    }

    [TestClass]
    public class CalculateTipForDictionaryTests
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectTipAmounts()
        {
            // Arrange
            Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>
            {
                { "Pooja", 40.0M },
                { "Gurkirpal", 30.0M },
                { "Parneet", 25.0M }
            };
            float tipPercentage = 18.0f;
            Dictionary<string, decimal> expectedTipAmounts = new Dictionary<string, decimal>
            {
                { "Pooja", 7.2M },
                { "Gurkirpal", 5.4M },
                { "Parneet", 4.5M }
            };

            // Act
            Dictionary<string, decimal> actualTipAmounts = CalculateTipForDictionary.Calculate(mealCosts, tipPercentage);

            // Assert
            CollectionAssert.AreEqual(expectedTipAmounts, actualTipAmounts);
        }
    }

    [TestClass]
    public class CalculateTipPerPersonTests
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectTipPerPerson()
        {
            // Arrange
            decimal totalPrice = 150.0M;
            int numPatrons = 5;
            float tipPercentage = 18.0f;
            decimal expectedTipPerPerson = 5.4M;

            // Act
            decimal actualTipPerPerson = CalculateTipPerPerson.Calculate(totalPrice, numPatrons, tipPercentage);

            // Assert
            Assert.AreEqual<decimal>(expectedTipPerPerson, actualTipPerPerson);
        }
    }
}
