//Name:         Roger Silva Santos Aguiar
//Initial date: February 24, 2021

using System;
using System.IO;
using System.Linq;
using System.Text;

class LotteryGamesByFrequency: LotteryGames
{
    public LotteryGamesByFrequency(string fileWithResults)
    {
        FileWithResults = fileWithResults;
    }

    public override string[] GenerateGames()
    {
        string [] results = null;
        return results;
    }

    public override string [] GetPastResults()
    {
        string currentLineOfFile;
        string fileWithResults = null;
        System.IO.StreamReader filePath = new System.IO.StreamReader(FileWithResults);
        for(int line = 0; (currentLineOfFile = filePath.ReadLine()) != null; line++)
        {
            fileWithResults += currentLineOfFile;
        }
        string [] past_results = fileWithResults.Split(' ', '\n');
        
        return past_results;   
    }

    public override string GetLayoutGame()
    {
        string layout = null;
        foreach (var number in Game)
        {
            layout += number + "   "; 
        }
        return layout;
    }
    
}