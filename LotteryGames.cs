//Name:         Roger Silva Santos Aguiar
//Initial date: February 24, 2021

using System.Collections.Generic;
public abstract class LotteryGames
{
    private int quantityOfAvailableNumbers;
    private int quantiyOfNumbersByGame;
    private string fileWithResults;
    private List<string> available_numbers = new List<string>();
    private List<string> game = new List<string>();
    private List<string> pastResults = new List<string>();
    List<int> frequency_of_numbers = new List<int>();

    public int QuantityOfAvailableNumbers { get => quantityOfAvailableNumbers; set => quantityOfAvailableNumbers = value; }
    public int QuantiyOfNumbersByGame { get => quantiyOfNumbersByGame; set => quantiyOfNumbersByGame = value; }
    public string FileWithResults { get => fileWithResults; set => fileWithResults = value; }   
    public List<string> PastResults { get => pastResults; set => pastResults = value; }
    public List<string> Game { get => game; set => game = value; }
    public List<string> Available_numbers { get => available_numbers; set => available_numbers = value; }
    public List<int> Frequency_of_numbers { get => frequency_of_numbers; set => frequency_of_numbers = value; }

    public abstract void GenerateGames();
    public abstract string GetLayoutGame();
    public abstract void GetPastResults();

}