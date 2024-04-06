string? valeurCh;
string valeurChMaj;
int valeur;
bool isVal;
bool isValScaleOk;
bool isRoleOk;

Console.WriteLine("Veuillez entrer une valeur comprise entre 5 et 10 !");
do
{
    valeurCh = Console.ReadLine();
    isVal = int.TryParse(valeurCh, out valeur);
    if (!isVal)
        Console.WriteLine("Désolé! Nombre invalide ! Recommencez !");
    isValScaleOk = valeur>=5 && valeur<=10;
    if (isVal && !isValScaleOk)
        Console.WriteLine($"Vous avez entré {valeur}. Veuillez entrer une valeur comprise entre 5 et 10 !");
}while (!isVal || !isValScaleOk);
Console.WriteLine($"Valeur {valeur} acceptée !\n");

do
{
    Console.WriteLine("Veuillez entrer votre rôle (Administrator, Manager ou User) !");
    valeurCh = Console.ReadLine();
    valeurChMaj = valeurCh.Trim().ToLower();
    valeurChMaj = char.ToUpper(valeurChMaj[0])+valeurChMaj.Substring(1);
    isRoleOk = valeurChMaj=="Administrator" || valeurChMaj=="Manager" || valeurChMaj=="User";
    if (!isRoleOk)
        Console.WriteLine($"Rôle {valeurCh} invalide !");
}while (!isRoleOk);
Console.WriteLine($"Valeur {valeurCh} acceptée !\n");

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;
string workString;
foreach(string myString in myStrings)
{
    workString = myString;
    do
    {
        periodLocation = workString.IndexOf(".");
        if (periodLocation!=-1)
        {
            Console.WriteLine(workString.Substring(0, periodLocation));
            workString = workString.Remove(0, periodLocation+1).TrimStart(); 
        }
        else
            Console.WriteLine(workString);     
              
    } while(periodLocation!=-1);
}