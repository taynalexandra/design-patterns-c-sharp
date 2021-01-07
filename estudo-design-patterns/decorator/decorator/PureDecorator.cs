using decorator.Interfaces;

namespace decorator
{
    public class PureDecorator : CachorroQuenteDecorator
    {
        //Concrete Decorator
        public PureDecorator(ICachorroQuente cachorroQuente)
            : base(cachorroQuente)
        {

        }

        public override string BuscarTipoCachorroQuente()
        {
            var pizza = base.BuscarTipoCachorroQuente();
            pizza += "\r\n + Purê";

            return pizza;
        }
    }
}