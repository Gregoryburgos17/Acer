using System;

namespace SystemBancario
{
    class Certificado
    {

        public void certificado()
        {
            Random num = new Random();
            string MENS = $"banco dominicano {num.Next(100000, 200000)}";
        }
    }
}
