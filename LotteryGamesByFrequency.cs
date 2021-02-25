using System;
using System.Linq;

class LotteryGamesByFrequency: LotteryGames
{    
    public LotteryGamesByFrequency(string fileWithResults, int quantityOfAvailableNumbers, int quantiyOfNumbersByGame)
    {
        FileWithResults = fileWithResults;
        QuantityOfAvailableNumbers = quantityOfAvailableNumbers;
        QuantiyOfNumbersByGame = quantiyOfNumbersByGame;
    }
    private void GetFrequencyOfNumbers()
    {       
        foreach (var number in Available_numbers)
        {
            var frequency = from current_number in PastResults
                            where current_number == number
                            select current_number;
            Frequency_of_numbers.Add(frequency.Count());                     
        }        
    }
    private void GetAvailableNumbers()
    {        
        for(int number = 1; number <= QuantityOfAvailableNumbers; number++)
            Available_numbers.Add(String.Format("{0:00}", number));        
    }

    public override void GenerateGames()
    {
        GetPastResults();
        GetAvailableNumbers();
        GetFrequencyOfNumbers();
        
        for(int number = 1; number <= QuantiyOfNumbersByGame; number++)
        {
            Game.Add(Available_numbers[Frequency_of_numbers.IndexOf(Frequency_of_numbers.Max())]);
            Available_numbers.RemoveAt(Frequency_of_numbers.IndexOf(Frequency_of_numbers.Max()));
            Frequency_of_numbers.RemoveAt(Frequency_of_numbers.IndexOf(Frequency_of_numbers.Max()));  
        }      

        Game.Sort();                          
    }    

    public override void GetPastResults()
    {
        string currentLineOfFile;        
        System.IO.StreamReader filePath = new System.IO.StreamReader(FileWithResults);
        
        for(int line = 0; (currentLineOfFile = filePath.ReadLine()) != null; line++)        
            FileWithResults += currentLineOfFile + '\t';
        
        string [] past_results = FileWithResults.Split(' ', '\t');
        PastResults = past_results.ToList();                  
    }

    public override string GetLayoutGame()
    {
        string layout = null;
        foreach (var number in Game)        
            layout += number + "   "; 
        
        return layout;
    }    
}