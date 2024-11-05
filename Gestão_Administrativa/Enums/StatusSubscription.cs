using System.ComponentModel;

namespace Gestão_Administrativa.Enums
{
    public enum StatusSubscription
    {
        [Description("Ativo")]
        Ativo = 1,
        [Description("Inativo")]
        Inativo = 2,
        [Description("Aguardando")]
        Aguardando = 3

    }
}
