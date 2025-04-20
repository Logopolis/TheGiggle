namespace TheGiggle;

public class DiceRoll
{
    public int NumberOfDice { get; }
    public int DiceType { get; }
    public int Bonus { get; }
    public DiceCheat DiceCheat { get; }

    protected static Random Random = new Random();

    public DiceRoll(
        int numberOfDice,
        int diceType,
        int bonus,
        DiceCheat diceCheat = DiceCheat.None)
    {
        NumberOfDice = numberOfDice;
        DiceType = diceType;
        Bonus = bonus;
        DiceCheat = diceCheat;
    }

    public static int Roll(
        int NumberOfDice,
        int DiceType,
        int Bonus,
        DiceCheat DiceCheat = DiceCheat.None)
    {
        return new DiceRoll(DiceType, NumberOfDice, Bonus, DiceCheat)
            .GetResult();
    }

    public virtual int GetResult()
    {
        var result = 0;
        for (int i = 0; i < NumberOfDice; i++)
        {
            result += RollOneDie();
        }

        return result + Bonus;
    }

    protected virtual int RollOneDie() => DiceCheat switch
    { 
        DiceCheat.None => Random.Next(DiceType) + 1,
        DiceCheat.MaxValue => DiceType,
        DiceCheat.MinValue => 1,
        _ => throw new NotImplementedException(DiceCheat.ToString())
    };
}

public enum DiceCheat
{
    None,
    MaxValue,
    MinValue
}