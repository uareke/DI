using DI.Attributes;
using DI.Enum;

namespace DI.Services.Interfaces;

[TipoInjecao(EnumTipoInjecao.Scoped)]
public interface IHelperService
{
    int SomaDoisNumeros(int valor1, int valor2);
}
