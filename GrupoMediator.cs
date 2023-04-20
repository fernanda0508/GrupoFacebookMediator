using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoFacebook
{
    //A classe GrupoMediator representa o grupo e tem uma lista de objetos que serão do do tipo IntegranteGrupo.
    public class GrupoMediator
    {
        private List<IntegranteGrupo> usuarios = new List<IntegranteGrupo>();

        // O método AdicionarUsuario é usado para adicionar um objeto IntegranteGrupo
        // à lista de usuários do grupo
        public void AdicionarUsuario(IntegranteGrupo usuario)
        {
            usuarios.Add(usuario);
        }

        //O método EnviarMensagem é usado para enviar uma mensagem do grupo para todos os usuários,
        //exceto o remetente da mensagem.
        public void EnviarMensagem(Mensagem mensagem)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario != mensagem.Remetente)
                {
                    usuario.ReceberMensagem(mensagem);
                }
            }
        }
    }
}
