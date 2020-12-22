using System;
using System.Threading;

namespace SystemBancario
{
    class Accionistas : IDivisasUSA
    {
        public void Actualizar()
        {
            if (DivisasUSA.Acciones < 58)
            {
                Thread.Sleep(5000);//Espera 3 sg
                double dolaractual = 58.30;
                Console.WriteLine("Las acciones estan SUBIENDO...");
                Console.WriteLine($"vendiendo acciones {dolaractual}%");
            }
        }
    }
}
