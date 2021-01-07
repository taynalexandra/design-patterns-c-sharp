using decorator.Interfaces;

namespace decorator
{
    public class CachorroQuente : ICachorroQuente
    {
        public string BuscarTipoCachorroQuente()
        {
            var cachorroQuente = "Cachorro Quente Normal";

            return cachorroQuente;
        }
    }
}
