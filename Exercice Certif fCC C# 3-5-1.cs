int ptsVieMonstre = 10;
int ptsVieHeros = 10;
Random combat = new Random();
int attaque;

do
{
    attaque = combat.Next(1,11);
    ptsVieMonstre -= attaque;
    if (ptsVieMonstre<0)
        ptsVieMonstre = 0;
    Console.WriteLine($"Monstre : {attaque}pts perdus, {ptsVieMonstre}pts restants");
    if (ptsVieMonstre>0)
    {
        attaque = combat.Next(1,11);
        ptsVieHeros -= attaque;
        if (ptsVieHeros<0)
            ptsVieHeros = 0;
        Console.WriteLine($"Héros : {attaque}pts perdus, {ptsVieHeros}pts restants");
    }
} while (ptsVieMonstre>0 && ptsVieHeros>0);

if (ptsVieMonstre==0)
    Console.WriteLine("Le gagnant est le héros !");
else 
    Console.WriteLine("Le gagnant est le monstre !");