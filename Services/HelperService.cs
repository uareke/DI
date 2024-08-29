using DI.Services.Interfaces;

namespace DI.Services
{
    public class HelperService : IHelperService
    {
        /// <summary>
        /// Efetua a somatoria de sois numeros
        /// </summary>
        /// <param name="valor1">Valor a ser somado 1</param>
        /// <param name="valor2">Valor a ser somado 2</param>
        /// <returns>A soma dos dois numeros</returns>
        public int SomaDoisNumeros(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

    }
}
