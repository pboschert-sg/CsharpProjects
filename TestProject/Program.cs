int heroHealth = 10, monsterHealth = 10;

Random attack = new Random();

while (heroHealth > 0 && monsterHealth > 0) {
    int attackValue = attack.Next(1, 11);
    monsterHealth -= attackValue;
    Console.WriteLine($"Monster was damaged and lost {attackValue} health and now has {monsterHealth} health.");
    if (monsterHealth > 0) {
        attackValue = attack.Next(1, 11);
        heroHealth -= attackValue;
        Console.WriteLine($"Hero was damaged and lost {attackValue} health and now has {heroHealth} health.");
    }
}

if(heroHealth > 0) {
    Console.WriteLine("Hero wins!");
} else {
    Console.WriteLine("Monster wins!");
}