using DI.Attributes;
using DI.Enum;

namespace DI.Services.Interfaces;

[TipoInjecao(EnumTipoInjecao.Transient)]
public interface ITokenService
{
    string GeraToken();
}
