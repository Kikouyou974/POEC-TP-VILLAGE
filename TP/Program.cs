
using TP;

void main()
{
    Village myVillage = new Village("Victor le createur");
    Console.WriteLine(myVillage.GetName()); // affichera Victor le createur
    Console.WriteLine(myVillage.listHouse.ToArray().Length); // affichera 1
}

main();