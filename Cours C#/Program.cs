int nbFacture;
    try
    {
        Console.WriteLine("Entrez le nombre de factures");
        nbFacture = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Saisie incorect appuyez sur une touche pour quitter");
        throw;

    }



float i = 1;
float sommeFacture = 0;
while (i <= nbFacture)
{
    Console.WriteLine("Quel est le montant de la facture " + i);
    float prixFacture = Convert.ToInt32(Console.ReadLine());
    sommeFacture += prixFacture;
    i++;
}
Console.WriteLine("Somme des factures en brut annuel " + sommeFacture + "€");
Console.WriteLine("Somme des factures en net annuel " + sommeFacture * 0.75 + "€");
Console.WriteLine("Facture par mois net " + (sommeFacture * 0.75) / 12 + "€");
Console.WriteLine("Facture par mois brut " + sommeFacture / 12 + "€");

if (sommeFacture > 36800)
{
    Console.WriteLine("Le plafond brut est dépassé de " + (sommeFacture - 36800) + "€");
}