using decorator.Interfaces;

namespace decorator
{
    public class CalabresaDecorator : CachorroQuenteDecorator
    {
        //Concrete Decorator
        public CalabresaDecorator(ICachorroQuente cachorroQuente)
            : base(cachorroQuente)
        {

        }

        public override string BuscarTipoCachorroQuente()
        {
            var pizza = base.BuscarTipoCachorroQuente();
            pizza += "\r\n + Calabresa";

            return pizza;
        }
    }
}
