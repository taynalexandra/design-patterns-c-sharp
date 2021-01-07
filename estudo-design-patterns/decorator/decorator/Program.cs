using decorator.Interfaces;
using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICachorroQuente cachorroQuente = new CachorroQuente();
            ICachorroQuente pureDecorator = new PureDecorator(cachorroQuente);
            ICachorroQuente baconDecorator = new BaconDecorator(pureDecorator);
            ICachorroQuente calabresaDecorator = new CalabresaDecorator(baconDecorator);

            Console.WriteLine(calabresaDecorator.BuscarTipoCachorroQuente());
        }
    }
}
