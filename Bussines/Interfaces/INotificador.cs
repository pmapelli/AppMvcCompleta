using Bussines.Notificacos;
using System.Collections.Generic;

namespace Bussines.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}