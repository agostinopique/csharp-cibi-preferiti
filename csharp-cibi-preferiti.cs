
//Dichiarato ed assegnati valori all'array
string[] cibiPreferiti = { "Carbonara", "Pizza", "Lasagne", "Tortelli burro e salvia" };

// Stampa la lunghezza della classifica
int length = cibiPreferiti.Length;

Console.WriteLine("Numero di cibi preferiti " + length);

// Stampa ogni classifica e la sua posizione in ordine
for( int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(i + ")" + cibiPreferiti[i]);
}

// Stampa il tuo cibo preferito
Console.WriteLine("Il mio cibo preferito é " + cibiPreferiti[0]);


// Stampa il tuo cibo preferito all'ultima posizione
int lastElement = cibiPreferiti.Length - 1;

Console.WriteLine("Il mio cibo un pò meno preferito é " + cibiPreferiti[lastElement]);