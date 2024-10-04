Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("welcome to knight vs goblin");
Console.WriteLine("___________________________");

Random randomnummergenerator = new Random();
Console.WriteLine("geef knight health op: ");
string input = (Console.ReadLine());

int knightHealth;
if (int.TryParse(input, out knightHealth))
{
    if (knightHealth < 0 || knightHealth > 100)
    {
        Console.WriteLine("default waarde 100 gegeven");
        knightHealth = 100;
    }
}
else
{
    knightHealth = 100;
}


int goblinHealth = randomnummergenerator.Next(1, 101);

//while (knightHealth > 0 || goblinHealth > 0){



Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("knightHealth: " + knightHealth);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("goblinHealth: " + goblinHealth);

//for (int attempts = 1; attempts <= 4; attempts++)
do
{

    //Console.WriteLine($"ronde: {attempts}");

    int attackKnight = 10;
    int attackGoblin = randomnummergenerator.Next(5, 16);

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("kies actie: ");
    Console.WriteLine("1: attack");
    Console.WriteLine("2: heal");
    string actie = Console.ReadLine();

    switch (actie)
    {

        case "1":
            goblinHealth -= attackKnight;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"knight attacks -10 goblin health: {goblinHealth}");
            break;

        case "2":
            knightHealth += 10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"knight heals + 10 knight healt: {knightHealth}");
            break;



        default:
            Console.WriteLine("invallid move");
            break;
    }
    if (goblinHealth > 0)
    {
        knightHealth -= attackGoblin;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"goblinHealth attack -5 knight health: {knightHealth}");
    }


    if (knightHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" knight dead");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" knight health: " + knightHealth);
    }


    if (goblinHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("goblin dead");

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" goblin health: " + goblinHealth);
    }

    Console.ForegroundColor = ConsoleColor.White;

}
while (knightHealth > 0 && goblinHealth >0);






/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
