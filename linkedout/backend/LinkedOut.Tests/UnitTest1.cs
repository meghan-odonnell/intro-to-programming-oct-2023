namespace LinkedOut.Tests;

public class UnitTest1
{
    [Fact]
    public void CanAddTwoIntegers()


    {
        // Given - "Arrange" - "setup the world"
        int a = 10;
        int b = 20;
        int total;

        // When - "Act" - poke and see what happens
        total = a + b; // System under Test SUT

        // Then "Assert" - find out
        Assert.Equal(30, total);

    }



}