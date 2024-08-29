using DI.Enum;

namespace DI.Attributes
{
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public class TipoInjecaoAttribute : Attribute
    {
        public EnumTipoInjecao Tipo { get; }

        public TipoInjecaoAttribute(EnumTipoInjecao tipo)
        {
            Tipo = tipo;
        }
    }
}
