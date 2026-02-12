
using System.Diagnostics.Eventing.Reader;

public class Calculator
{
    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }

        numbers = numbers.Replace("\n", ",");

        if(!numbers.Contains(","))
        {
            return int.Parse(numbers);
        }
        else
        {
            var splitNumbers = numbers.Split(',');
            int sum = 0;
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                sum += int.Parse(splitNumbers[i]);
            }
            return sum;
        }



        return 0;
    }
}
