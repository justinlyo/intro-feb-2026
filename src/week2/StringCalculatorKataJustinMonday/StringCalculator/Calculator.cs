

// Interface Segregation PRINCIPLE (ISP)
    // you define what you need, don't just use what is available


public interface ILogger
{
    void LogAddResults(string results);
}

public interface INotifyTheHelpDesk
{
    void Notify(string v);
}

public class Calculator(ILogger _logger, INotifyTheHelpDesk _helpDesk)
{
    public int Add(string numbers)
    {
        
       
        var result = numbers == "" ? 0 :  numbers // "1,2,3,4"
            .Split(',', '\n') // ["1", "2", "3", "4"]
            .Select(int.Parse) // [1, 2, 3, 4]
            .Sum(); // 10

        // Do something here
        // this is a non-functional or technical requirement
        // side effect jst means something is happening
        // that doesnt change the observable behavior of the
        // caller of this method
        // logging is "leaving the escape room" - leaving the process
        // writing to the file system

        try
        {
            _logger.LogAddResults(result.ToString());
        }
        catch(Exception)
        {
            _helpDesk.Notify("Can't log: " + result.ToString());

        }
        

        return result;
        
        
 
    }
}


// Test Double
// Dummy - not really part of the test, just need something so we don't get a NRE
// Stub - a thing that has canned responses to questions. Simulating faults
