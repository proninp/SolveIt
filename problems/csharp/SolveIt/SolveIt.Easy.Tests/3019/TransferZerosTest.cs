using SolveIt.Easy._3019.src;

namespace SolveIt.Easy.Tests._3019;

public class TransferZerosTest
{
    [Fact]
    public void MoveZeroesTest_One()
    {
        /// Arrange
        var actual = new[] { 0, 1, 2, 0, 3 };
        var expected = new[] { 1, 2, 3, 0, 0 };
        
        Test(actual, expected);
    }
    
    [Fact]
    public void MoveZeroesTest_Two()
    {
        /// Arrange
        var actual = new[] { 1, 2, 3, 4, 5 };
        var expected = new[] { 1, 2, 3, 4, 5 };
        
        Test(actual, expected);
    }

    private void Test(int[] actual, int[] expected)
    {
        /// Act
        TransferZeros.MoveZeroes(actual);
        
        /// Assert
        Assert.Equal(actual, expected);
    }
}