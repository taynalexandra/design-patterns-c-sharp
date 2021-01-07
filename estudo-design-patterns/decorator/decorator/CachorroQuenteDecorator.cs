using decorator.Interfaces;

namespace decorator
{
    //Base Decorator
    public class CachorroQuenteDecorator : ICachorroQuente
    {
        private readonly ICachorroQuente _cachorroQuente;

        public CachorroQuenteDecorator(ICachorroQuente cachorroQuente)
        {
            _cachorroQuente = cachorroQuente;

        }

        public virtual string BuscarTipoCachorroQuente()
        {
            var cachorroQuente = _cachorroQuente.BuscarTipoCachorroQuente();
            
            return cachorroQuente;
        }
    }
}
