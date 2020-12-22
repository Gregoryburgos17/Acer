using System;

namespace SystemBancario
{
    class Prestamo
    {
        public int numPrestamo;
        public double montoPrestamo;
        public double tasaPrestamo;
        Random Presta = new Random();

        public Prestamo(double monto, double tasa)
        {
            numPrestamo = Presta.Next(1000, 9999);
            montoPrestamo = monto;
            tasaPrestamo = tasa;
        }


        public void montodeP()
        {
            Console.WriteLine($"***Prestamo solicitado***\n" +
                $"Numero  de prestamo: #{numPrestamo}\n" +
                $"Monto Total: {montoPrestamo}\n" +
                $"Tasa a cobrar: {tasaPrestamo}%");

        }
    }
}
