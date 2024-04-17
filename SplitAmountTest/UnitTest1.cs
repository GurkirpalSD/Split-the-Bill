
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

        [TestMethod]
        public void Split_ZeroAmount_ReturnsZero()
        {
            // Arrange
            decimal amount = 0M;
            int numPeople = 5;

            // Act
            decimal actualSplit = SplitAmount.Split(amount, numPeople);

            // Assert
            Assert.AreEqual(0M, actualSplit);
        }

        [TestMethod]
        public void Split_NegativeAmount_ReturnsZero()
        {
            // Arrange
            decimal amount = -100M;
            int numPeople = 5;

            // Act
            decimal actualSplit = SplitAmount.Split(amount, numPeople);

            // Assert
            Assert.AreEqual(0M, actualSplit);
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
        { "Pooja", 7.20M },
        { "Gurkirpal", 5.40M },
        { "Parneet", 4.50M }
    };

    // Act
    Dictionary<string, decimal> actualTipAmounts = CalculateTipForDictionary.Calculate(mealCosts, tipPercentage);

    // Assert
    CollectionAssert.AreEqual(expectedTipAmounts, actualTipAmounts);
}

[TestMethod]
public void Calculate_EmptyMealCosts_ReturnsEmptyDictionary()
{
    // Arrange
    Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>();
    float tipPercentage = 15.0f;

    // Act
    Dictionary<string, decimal> actualTipAmounts = CalculateTipForDictionary.Calculate(mealCosts, tipPercentage);

    // Assert
    Assert.AreEqual(0, actualTipAmounts.Count);
}

[TestMethod]
public void Calculate_ZeroTipPercentage_ReturnsZeroTipAmounts()
{
    // Arrange
    Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>
    {
        { "Pooja", 40.0M },
        { "Gurkirpal", 30.0M },
        { "Parneet", 25.0M }
    };
    float tipPercentage = 0.0f;

    // Act
    Dictionary<string, decimal> actualTipAmounts = CalculateTipForDictionary.Calculate(mealCosts, tipPercentage);

    // Assert
    CollectionAssert.AreEqual(new Dictionary<string, decimal>(), actualTipAmounts);
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

        [TestMethod]
        public void Calculate_ZeroTotalPrice_ReturnsZeroTipPerPerson()
        {
            // Arrange
            decimal totalPrice = 0M;
            int numPatrons = 5;
            float tipPercentage = 15.0f;

            // Act
            decimal actualTipPerPerson = CalculateTipPerPerson.Calculate(totalPrice, numPatrons, tipPercentage);

            // Assert
            Assert.AreEqual(0M, actualTipPerPerson);
        }

        [TestMethod]
        public void Calculate_NegativeTipPercentage_ReturnsZeroTipPerPerson()
        {
            // Arrange
            decimal totalPrice = 150.0M;
            int numPatrons = 5;
            float tipPercentage = -10.0f;

            // Act
            decimal actualTipPerPerson = CalculateTipPerPerson.Calculate(totalPrice, numPatrons, tipPercentage);

            // Assert
            Assert.AreEqual(0M, actualTipPerPerson);
        }
    }
}
