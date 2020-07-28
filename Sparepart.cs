using System;

namespace Abstraction.Abstractclass
{
    public class Sparepart : Bengkel
    {
        public override void Pesanan()
        {
            Console.WriteLine("Maaf Sparepart dalam proses pengiriman");
        }
    }
}