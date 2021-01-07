using decorator.Interfaces;

namespace decorator
{
    public class BaconDecorator : CachorroQuenteDecorator
    {
        //Concrete Decorator
        public BaconDecorator(ICachorroQuente cachorroQuente)
            : base(cachorroQuente)
        {

        }

        public override string BuscarTipoCachorroQuente()
        {
            var pizza = base.BuscarTipoCachorroQuente();
            pizza += "\r\n + Bacon";

            return pizza;
        }
    }
}