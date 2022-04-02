using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

bool band = false;
Console.Write("Por favor ingrese su nombre: ");
string nombre = Console.ReadLine();
do
{
   
    Console.WriteLine("Hola " + nombre + ".");

    Console.Write("Por favor " + nombre + " ingresa una frase: ");
    string frase = Console.ReadLine();
    string fin = "fin";
    bool flag = frase.Contains(fin);

    if (flag == true)
    {
        Console.WriteLine("La frase ingresada contiene la palabra " + fin + ".");
        band = true;
    }
} while (band == false);
