using System;

//nome repo: csharp - functions
//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

//void StampaArray(int[] array):
//che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//Potete prendere quella fatta in classe questa mattina

int[] arrayDaStampare = { 2, 6, 7, 5, 3, 9 };

StampaArray(arrayDaStampare);

void StampaArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

Console.WriteLine("inserisci un numero");
int numeroUtente = Convert.ToInt32(Console.ReadLine());

int numeroAlQuadrato = Quadrato(numeroUtente);

int Quadrato(int numero)
{
    return numero * numero;
}

Console.WriteLine("il quadrato del tuo numero è: " + numeroAlQuadrato);

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

int[] arrayDaElevare = { 2, 6, 7, 5, 3, 9 };

ElevaArrayAlQuadrato(arrayDaElevare);

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayAlQuadrato = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrayAlQuadrato[i] = array[i] * array[i];
    }
    return arrayAlQuadrato;
}

//int SommaElementiArray(int[] array):
//che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int[] arrayDaSommare = { 2, 6, 7, 5, 3, 9 };

int SommaTotaleArray = SommaElementiArray(arrayDaSommare);

int SommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}

Console.WriteLine(SommaTotaleArray);

//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9]
//già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati

//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
//ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
//A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.

Console.WriteLine("Da quanti numeri è composto l'array?");
int lunghezzaArray = Convert.ToInt32(Console.ReadLine());

int[] arrayutente = new int[lunghezzaArray];

for( int i = 0; i < arrayutente.Length; i++)
{
    Console.WriteLine($"Inserisci il numero {i + 1} di {lunghezzaArray}");
    arrayutente[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Stampa array di numeri");
StampaArray(arrayutente);

Console.WriteLine("Stampa array di numeri elevati al quadrato");
StampaArray(ElevaArrayAlQuadrato(arrayutente));

Console.WriteLine("Somma di tutti i numeri");
Console.WriteLine(SommaElementiArray(arrayutente));

Console.WriteLine("Somma di tutti i numeri elevati al quadrato");
Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(arrayutente)));
