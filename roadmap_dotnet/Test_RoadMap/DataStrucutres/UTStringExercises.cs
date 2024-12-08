namespace TestsCSharpFoundation.DSA;
using CSharpFoundation.DSA;

public class UTStringExercises
{

    [Fact]
    public void testReverseWordsInAGivenString()
    {
        // Given
        var input = "geeks quiz practice code";
        var expectedResult = "code practice quiz geeks";
        // When
        var actualResult = StringExercises.ReverseWordsInAGivenString(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void testReverseWordsInAGivenString2thdScenario()
    {
        // Given
        var input = "i love programming very much";
        var expectedResult = "much very programming love i";
        // When
        var actualResult = StringExercises.ReverseWordsInAGivenString(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void testLongestCommonPrefixUsingSorting()
    {
        // Given
        var input = new[] { "geeksforgeeks", "geeks", "geek", "geezer" };
        var expectedResult = "gee";
        // When
        var actualResult = StringExercises.LongestCommonPrefixUsingSorting(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void testLongestCommonPrefixUsingSorting2thdScenario()
    {
        // Given
        var input = new[] { "apple", "ape", "april" };
        var expectedResult = "ap";
        // When
        var actualResult = StringExercises.LongestCommonPrefixUsingSorting(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestConvertingRomanNumeralsToDecimal()
    {
        // Given
        var input = "IX";
        var expectedResult = 9;
        // When
        var actualResult = StringExercises.ConvertingRomanNumeralsToDecimal(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestConvertingRomanNumeralsToDecimal3thdCenario()
    {
        // Given
        var input = "XL";
        var expectedResult = 40;
        // When
        var actualResult = StringExercises.ConvertingRomanNumeralsToDecimal(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestConvertingRomanNumeralsToDecimal4thdCenario()
    {
        // Given
        var input = "MCMIV";
        var expectedResult = 1904;
        // When
        var actualResult = StringExercises.ConvertingRomanNumeralsToDecimal(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void testConvertNumberToRoman()
    {
        // Given
        var input = 9;
        var expectedResult = "IX";
        // When
        var actualResult = StringExercises.ConvertNumberToRoman(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void testConvertNumberToRomanSecoundScenario()
    {
        // Given
        var input = 3549;
        var expectedResult = "MMMDXLIX";
        // When
        var actualResult = StringExercises.ConvertNumberToRoman(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void testConvertNumberToRomanThirdcenario()
    {
        // Given
        var input = 3649;
        var expectedResult = "MMMDCXLIX";
        // When
        var actualResult = StringExercises.ConvertNumberToRoman(input);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestMinimumDistanceBetweenWordsOfAString()
    {
        /// Given
        var input = "geeks for geeks contribute practice";
        var tokens = new string[] { "geeks", "practice" };
        var expectedResult = 1;
        // When
        var actualResult = StringExercises.MinimumDistanceBetweenWordsOfAString(input, tokens);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestMinimumDistanceBetweenWordsOfAStringSecoundScenario()
    {
        /// Given
        var input = "the quick the brown quick brown the frog";
        var tokens = new string[] { "quick", "frog" };
        var expectedResult = 2;
        // When
        var actualResult = StringExercises.MinimumDistanceBetweenWordsOfAString(input, tokens);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void testStringsAreIsomorphic()
    {
        /// Given
        var firstWord = "aab";
        var secoundWord = "xxy";
        var expectedResult = true;
        // When
        var actualResult = StringExercises.StringsAreIsomorphic(firstWord, secoundWord);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void testStringsAreIsomorphicSecoundScenario()
    {
        /// Given
        var firstWord = "aab";
        var secoundWord = "xyz";
        var expectedResult = false;
        // When
        var actualResult = StringExercises.StringsAreIsomorphic(firstWord, secoundWord);
        // Then
        Assert.Equal(expectedResult, actualResult);
    }
}