
//Dichiarato ed assegnati valori all'array
string[] cibiPreferiti = { "Carbonara", "Pizza", "Lasagne", "Tortelli burro e salvia" };

// Stampa la lunghezza della classifica
int length = cibiPreferiti.Length;

Console.WriteLine("Numero di cibi preferiti " + length);

#region 
// Stampa ogni classifica e la sua posizione in ordine
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine((i + 1) + ")" + cibiPreferiti[i]);
}
#endregion

// Stampa il tuo cibo preferito
Console.WriteLine("Il mio cibo preferito é " + cibiPreferiti[0]);


// Stampa il tuo cibo preferito all'ultima posizione
int lastElement = cibiPreferiti.Length - 1;

Console.WriteLine("Il mio cibo un pò meno preferito é " + cibiPreferiti[lastElement]);


// Stampa il cibo di mezza classifica;

#region
// Troviamo il centro della classifica;
int mediana = length / 2;

// Se il modulo mi ritorna 0 vuol dire che é pari e dovrò prendere l'elemento entrale più l'elemento precedente;
if(length % 2 == 0)
{
    Console.Write("I cibi di mediana sono: ")
    Console.WriteLine(cibiPreferiti[mediana]);
    Console.WriteLine(cibiPreferiti[mediana - 1]);
}
// Altrimenti se non ritorna 0 é dispari e potrò prendere semplicemente l'elemento al centr otramite il rimanente della divisione;
else
{
    Console.Write("Il cibo di mediana é: ")
    Console.WriteLine(cibiPreferiti[mediana]);
}

#endregion