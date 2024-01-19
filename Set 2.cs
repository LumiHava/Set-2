// Ex 1:
//Se da o secventa de n numere.Sa se determine cate din ele sunt pare

/* Console.WriteLine("Introduceti secventa de numere:");
 int n = int.Parse(Console.ReadLine());

 int[] secventa = new int[n];

 for (int i = 0; i < n; i++)
 {
     Console.WriteLine($"Introduceti elementul {i + 1}:");
     secventa[i] = int.Parse(Console.ReadLine());
 }


     int numerePare = NumerePare(secventa);
     Console.WriteLine($"In secventa urmatoare sunt {numerePare} numere pare.");

  static int NumerePare(int[] secventa)
  {



     int Contorpare = 0;

     foreach (int numar in secventa)
     {
         if (numar % 2 == 0)
         {
             Contorpare++;
         }
     }

     return Contorpare;
  }*/

// Ex 2:
// Se da o secventa de n numere. Sa se determina cate sunt negative, 
// cate sunt zero si cate sunt pozitive.

/* Console.WriteLine("Introduceti numarul de elemente in secventa: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int negative = 0;
 int positive = 0;
 int zero = 0;
 int produs = 1;
 int suma = 0;

 Console.WriteLine("Introduceti secventa de numere");

 for( int i = 0; i < n; i++)
 {
    int num = Convert.ToInt32(Console.ReadLine());
     if (num < 0)
     {
         negative++;

     }
     else if (num == 0)
     {
         zero++;
     }
     else
     {
         positive++;
     }

     suma += num;
     produs *= num;

     Console.WriteLine($"Numere negative: {negative}");
     Console.WriteLine($"Numere zero: {zero}");
     Console.WriteLine($"Numere pozitive: {positive}");
     Console.WriteLine($"Suma numerelor: {suma}");
     Console.WriteLine($"Produsul numerelor: {produs}");
 }*/

// Ex 3
// Calculati suma si produsul numerelor de la 1 la n.

/*Console.WriteLine("Introduceti un număr n:");
int n = Convert.ToInt32(Console.ReadLine());

int suma = 0;
int produs = 1;

for (int i = 1; i <= n; i++)
{
    suma += i;
    produs *= i;
}

Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");*/

// Ex 4
//Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.  
//Se considera ca primul element din secventa este pe pozitia zero. 
//Daca numarul nu se afla in secventa raspunsul va fi

/* Console.WriteLine("Introduceti lungimea secventei:");
 int n = Convert.ToInt32(Console.ReadLine());

 int[] secventa = new int[n];

 Console.WriteLine("Introduceti secventa de numere:");

 for (int i = 0; i < n; i++)
 {
     secventa[i] = Convert.ToInt32(Console.ReadLine());
 }

 Console.WriteLine("Introduceti numărul căutat în secventă:");
 int numarCautat = Convert.ToInt32(Console.ReadLine());

 int pozitie = GasestePozitia(secventa, numarCautat);

 Console.WriteLine($"Pozitia numarului {numarCautat} în secventă este: {pozitie}");
}

static int GasestePozitia(int[] secventa, int numarCautat)
{
 for (int i = 0; i < secventa.Length; i++)
 {
     if (secventa[i] == numarCautat)
     {
         return i;
     }
 }
 return -1;*/



/* Console.WriteLine("Introduceti secventa de numere");
 int[] secventa = { 0, 1, 2, 3, 4, };
 Console.WriteLine("Elementele din secventa care sunt egale cu pozitia lor sunt: ");

 for (int i = 0; i < secventa.Length; i++)
 {
     if (secventa[i] == i)
     {
         Console.WriteLine($"Elementul {secventa[i]} se afla pe pozitia {i}");


     }
 }
*/


// Ex 5


/*  int[] secventa = { 0, 1, 2, 3, 4, 5, 6 };



  int numarElementeEgaleCuPozitia = NumarElementeEgaleCuPozitia(secventa);
  Console.WriteLine($"Numărul de elemente egale cu pozitia lor în secventă este: {numarElementeEgaleCuPozitia}");


}

static int NumarElementeEgaleCuPozitia(int[] secventa)
{
  int count = 0;

  for (int i = 0; i < secventa.Length; i++)
  {
      if (secventa[i] == i)
      {

          count++;
      }
  }

  return count;*/

// Ex 6


/*  int[] numere = { 5,4,2,1 }; 


  bool esteCrescatoare = VerificaCrescatoare(numere);


  if (esteCrescatoare)
  {
      Console.WriteLine("Secventa este în ordine crescătoare.");
  }
  else
  {
      Console.WriteLine("Secventa nu este în ordine descrescătoare.");
  }
}


static bool VerificaCrescatoare(int[] arr)
{
  for (int i = 0; i < arr.Length - 1; i++)
  {

      if (arr[i] >= arr[i + 1])
      {
          return false; 
      }
  }
  return true;
*/

//Ex 7

/* Console.WriteLine("introduceti secventa de numere:");
 int n = Convert.ToInt32(Console.ReadLine());
 int[] numere = new int[n];

 for (int i = 0; i<n;i++)
 {
     Console.WriteLine("introduceti elementul" + (i+1)+ ":");
     numere[i]= Convert.ToInt32(Console.ReadLine());
 }

 int min = int.MaxValue;
 int max = int.MinValue;

 for (int i = 0; i < n; i++)
 {
     if (numere[i] < min)
     {
         min = numere[i];
     }
     if (numere[i] > max)
     {
         max = numere[i];
     }

 }
 Console.WriteLine("cea mai mica valoare este: " + min);
 Console.WriteLine("cea mai mare valoare este: " + max);*/

// Ex 9

/* Console.WriteLine("introduceti numarul de elemente: ");

 int n = Convert.ToInt32(Console.ReadLine());

 int[] numere = new int[n];

 for (int i = 0;i < n; i++)
 {
     Console.WriteLine("introduceti elementul" +(i + 1)+ ":");
     numere[i] = Convert.ToInt32(Console.ReadLine());
 }

 bool crescator = true;
 bool descrescator = true;

 for (int i = 1; i < n; i++)
 {
     if (numere[i] < numere[i - 1])
     {
         crescator = false;
     }
     if (numere[i] > numere[i - 1])
     {
         descrescator = false;
     }

 }

 if (crescator)
 {
     Console.WriteLine("secventa este monoton crescatoare");

 }

 else if (descrescator)
 {
     Console.WriteLine("secventa este monoton descrescatoare");

 }

 else
 {
     Console.WriteLine("secveta nu este monotona");
 }*/

// Ex 10

/* Console.Write("Introdu numarul de elemente: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int[] numere = new int[n];

 for (int i = 0; i < n; i++)
 {
     Console.Write("Introdu elementul " + (i + 1) + ": ");
     numere[i] = Convert.ToInt32(Console.ReadLine());
 }

 int max = 0;
 int curent = 1;

 for (int i = 1; i < n; i++)
 {
     if (numere[i] == numere[i - 1])
     {
         curent++;
         if (curent > max)
         {
             max = curent;
         }
     }
     else
     {
         curent = 1;
     }
 }

 Console.WriteLine("Numarul maxim de numere consecutive egale este: " + max);*/

// Ex 11

/* Console.Write("Introdu numarul de elemente n: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int[] numere = new int[n];

 for (int i = 0; i < n; i++)
 {
     Console.Write("Introdu elementul " + (i + 1) + ": ");
     numere[i] = Convert.ToInt32(Console.ReadLine());
 }

 double suma = SumaInverselor(numere);

 Console.WriteLine("Suma inverselor numerelor este: " + suma);
}

static double SumaInverselor(int[] numere)
{
 double suma = 0;
 foreach (int numar in numere)
 {
     if (numar != 0)
     {
         suma += 1.0 / numar;
     }
 }
 return suma;*/

// Ex 12

/* Console.Write("Introdu numarul de elemente n: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int[] numere = new int[n];

 for (int i = 0; i < n; i++)
 {
     Console.Write("Introdu elementul " + (i + 1) + ": ");
     numere[i] = Convert.ToInt32(Console.ReadLine());
 }

 int nrGrupuri = NumarGrupuri(numere);

 Console.WriteLine("Numarul de grupuri de numere consecutive diferite de zero este: " + nrGrupuri);
}

static int NumarGrupuri(int[] numere)
{
 int nrGrupuri = 0;
 bool inGrup = false;

 foreach (int numar in numere)
 {
     if (numar != 0)
     {
         if (!inGrup)
         {
             nrGrupuri++;
             inGrup = true;
         }
     }
     else
     {
         inGrup = false;
     }
 }

 return nrGrupuri;*/

// Ex 13

/*Console.Write("Introdu numarul de elemente n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numere = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Introdu elementul " + (i + 1) + ": ");
    numere[i] = Convert.ToInt32(Console.ReadLine());
}

bool esteRotita = EsteSecventaCrescatoareRotita(numere);

if (esteRotita)
{
    Console.WriteLine("Secventa este o secventa crescatoare rotita");
}
else
{
    Console.WriteLine("Secventa nu este o secventa crescatoare rotita");
}
}

static bool EsteSecventaCrescatoareRotita(int[] numere)
{
int punctDeRotire = -1;

for (int i = 0; i < numere.Length - 1; i++)
{
    if (numere[i] > numere[i + 1])
    {
        if (punctDeRotire == -1)
        {
            punctDeRotire = i;
        }
        else
        {
            return false;
        }

    }
}
return punctDeRotire == -1 || punctDeRotire == numere.Length - 1;*/

// EX 14

/*Console.Write("Introdu numarul de elemente n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numere = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Introdu elementul " + (i + 1) + ": ");
    numere[i] = Convert.ToInt32(Console.ReadLine());
}

bool esteRotita = EsteSecventaMonotonaRotita(numere);

if (esteRotita)
{
    Console.WriteLine("Secventa este o secventa monotona rotita");
}
else
{
    Console.WriteLine("Secventa nu este o secventa monotona rotita");
}
}

static bool EsteSecventaMonotonaRotita(int[] numere)
{
bool esteCrescatoare = true, esteDescrescatoare = true;

for (int i = 0; i < numere.Length - 1; i++)
{
    if (numere[i] > numere[i + 1])
    {
        esteCrescatoare = false;
    }
    if (numere[i] < numere[i + 1])
    {
        esteDescrescatoare = false;
    }
}

return (esteCrescatoare && numere[numere.Length - 1] <= numere[0]) ||
       (esteDescrescatoare && numere[numere.Length - 1] >= numere[0]);*/

//Ex 15

/*  Console.Write("Introdu numarul de elemente n: ");
  int n = Convert.ToInt32(Console.ReadLine());

  int[] numere = new int[n];

  for (int i = 0; i < n; i++)
  {
      Console.Write("Introdu elementul " + (i + 1) + ": ");
      numere[i] = Convert.ToInt32(Console.ReadLine());
  }

  bool esteBitonica = EsteSecventaBitonica(numere);

  if (esteBitonica)
  {
      Console.WriteLine("Secventa este bitonica");
  }
  else
  {
      Console.WriteLine("Secventa nu este bitonica");
  }
}

static bool EsteSecventaBitonica(int[] numere)
{
  if (numere.Length < 2)
  {
      return true;
  }

  int i = 0;

  while (i < numere.Length - 1 && numere[i] <= numere[i + 1])
  {
      i++;
  }

  if (i == numere.Length - 1)
  {
      return true;
  }

  while (i < numere.Length - 1 && numere[i] >= numere[i + 1])
  {
      i++;
  }

  return i == numere.Length - 1;*/
