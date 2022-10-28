// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. Potete prendere quella fatta in classe questa mattina
//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati


{

//    Console.WriteLine("________________ Array dinamico ______________");

//    Console.WriteLine("Quanti elementi vuoi nel tuo array?");
//    int elementiArray = Convert.ToInt16(Console.ReadLine());

//    int[] arrayNuovo = (creaArray(elementiArray));

//    StampaArray(arrayNuovo);
//    StampaArray(ElevaArrayAlQuadrato(arrayNuovo));
//    Console.WriteLine(SommaElementiArray(arrayNuovo));
//    Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(arrayNuovo)));




//    int[] creaArray(int elementiArray)
//    {
//        int[] arrayUtente = new int[elementiArray];

//        Console.WriteLine("Inseririsci" + " " + arrayUtente.Length + " " + "numeri");
//        for (int i = 0; i < elementiArray; i++)
//        {
//            int inputNumero = Convert.ToInt16(Console.ReadLine());
//            arrayUtente[i] = inputNumero;
//        }
//        return arrayUtente;
//    }



//    Console.WriteLine("______________ Array statitico ______________");


//    int[] numeri = {2, 6, 7, 5, 3, 9};

//    StampaArray(numeri);
//    StampaArray(ElevaArrayAlQuadrato(numeri));
//    Console.WriteLine(SommaElementiArray(numeri));
//    Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(numeri)));


    //Prima funzione stampa qualasisi array
    void StampaArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }


    //restituisce il quadrata del numero passato
    int Quadrato(int numero)
    {
        return numero * numero;
    }


    //da un array ne crea un nuovo con i valori elevati al quadrato
    int[] ElevaArrayAlQuadrato(int[] array)
    {
        int[] arrayQuadrato = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            arrayQuadrato[i] = Quadrato(array[i]);
        }
        return arrayQuadrato;
    }


    //Somma tutti gli elementi di un array
    int SommaElementiArray(int[] array)
    {
        int somma = 0;
        for (int i = 0; i < array.Length; i++)
        {
            somma = somma + array[i];
        }
            return somma;
    }




    //Calcolo fattoriale di un numero N
    Console.WriteLine("Inserisci il tuo numero per calcolarne il fattoriale");
    int fattorialeInput = Convert.ToInt16(Console.ReadLine());

    StampaArray(fattorialeArray(fattorialeInput));


    int[] fattorialeArray(int Input)
    {
        int numero = 1;
        int[] arrayUtente = new int[Input];

        for (int i = 0; i < Input; i++)
        {
            numero = numero * (i + 1);
            arrayUtente[i] = numero;
        }
        return arrayUtente;
    }



    //Calcolo di N numeri della seria di fibonacci
    Console.WriteLine("Inserisci il tuo numero per la serie di fibonacci");
    int fibonacciInput = Convert.ToInt16(Console.ReadLine());

    StampaArray(fibonacciArray(fibonacciInput));

    int[] fibonacciArray(int Input)
    {
        int[] arrayUtente = new int[Input + 1];

        for (int i = 0; i <= Input; i++)
        {
            if (i == 0)
            {
                arrayUtente[i] = 0;
            } 
            else if (i == 1)
            {
                arrayUtente[i] = 1;
            }
            else 
            {
                int numero = arrayUtente[i - 1] + arrayUtente[(i - 2)];
                arrayUtente[i] = numero;
            }

        }
        return arrayUtente;
    }
}



Console.WriteLine("Inserisci il tuo numero per calcolarne il fattoriale");
int fattorialeInputRicorsivo = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(fattorialeArrayRicorsiva(fattorialeInputRicorsivo));

int fattorialeArrayRicorsiva(int FaNumeroRi)
{
    if (FaNumeroRi == 1)
        return 1;
    else
        return FaNumeroRi * fattorialeArrayRicorsiva(FaNumeroRi - 1);
}






