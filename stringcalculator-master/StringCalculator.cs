
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        int sum;
        if (numbers.Length == 0)
        {
            return 0;
        }

        foreach (string number in numbers)
        {
            sum = int.Parse(number);


        }

    }
}
