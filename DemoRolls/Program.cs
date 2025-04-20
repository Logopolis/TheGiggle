using TheGiggle;

foreach (var d in new List<DiceRoll>([
    new DiceRoll(2, 6, 0),
    new DiceRoll(2, 12, 0),
    new DiceRoll(2, 12, 1),
    new DiceRoll(2, 12, 2),
    new DiceRoll(2, 12, 3),
    new DiceRoll(2, 12, 4),
    new DiceRoll(2, 12, 5),
    new DiceRoll(2, 12, 6),
]))
{ RollToConsole(d); }

Console.WriteLine($"{DiceRoll.Roll(20, 1, 10)} should be 30");

void RollToConsole(DiceRoll diceRoll)
{
    Console.WriteLine($"{diceRoll.NumberOfDice}d{diceRoll.DiceType}+{diceRoll.Bonus} [{diceRoll.DiceCheat}] = {diceRoll.GetResult()}");
}