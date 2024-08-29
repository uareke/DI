using DI.Attributes;
using DI.Enum;

namespace DI.Services.Interfaces
{
    [TipoInjecao(EnumTipoInjecao.Scoped)]
    public interface ITesteService
    {
    }
}
