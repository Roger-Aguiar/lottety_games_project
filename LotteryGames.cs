//Name:         Roger Silva Santos Aguiar
//Initial date: February 24, 2021

public abstract class LotteryGames
{
    private int quantityOfAvailableNumbers;
    private int quantiyOfNumbersByGame;
    private string fileWithResults;
    private string [] game;
    private string [] pastResults;

    public int QuantityOfAvailableNumbers { get => quantityOfAvailableNumbers; set => quantityOfAvailableNumbers = value; }
    public int QuantiyOfNumbersByGame { get => quantiyOfNumbersByGame; set => quantiyOfNumbersByGame = value; }
    public string FileWithResults { get => fileWithResults; set => fileWithResults = value; }
    public string[] Game { get => game; set => game = value; }
    public string[] PastResults { get => pastResults; set => pastResults = value; }
    

    public abstract string[] GenerateGames();
    public abstract string GetLayoutGame();
    public abstract void GetPastResults();

}