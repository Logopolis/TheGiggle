# TheGiggle
Dice rolls

# Sample code
```cs
DiceRoll fireballRoll = new DiceRoll(3,6,2) // 3d6 +2
int damage = fireballRoll.GetResult();

// or...
int fireballDamage = DiceRoll.Roll(3,6,2);
```