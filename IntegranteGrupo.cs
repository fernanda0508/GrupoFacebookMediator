using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoFacebook
{
   public class IntegranteGrupo
    {
        //armazena o nome do usuário
        public string Nome { get; set; }

        //armazena uma referência ao objeto GrupoMediator ao qual o usuário está associado
        public GrupoMediator Grupo { get; set; }

        //Quando um objeto IntegranteGrupo é criado, ele recebe um objeto
        //GrupoMediator como um de seus parâmetros.Essa referência ao
        //objeto GrupoMediator é armazenada na propriedade Grupo do
        //objeto objeto IntegranteGrupo, o que garante que cada usuário está
        //associado a um único grupo
        public IntegranteGrupo(string nome, GrupoMediator grupo)
        {
            
            Nome = nome;
            Grupo = grupo;

            // na criação o usuário é adicionado automaticamente à lista
            // de usuários do grupo. Isso garante que o grupo mantenha
            // uma lista atualizada de todos os usuários que
            // fazem parte dele.
            grupo.AdicionarUsuario(this);
        }

        public void EnviarMensagem(string conteudo)
        {
            //chama o método EnviarMensagem do objeto GrupoMediator, passando
            //o objeto Mensagem como um parâmetro
            Grupo.EnviarMensagem(new Mensagem(conteudo, this));
        }

        //étodo ReceberMensagem é usado para receber uma mensagem do grupo. Ele é chamado
        //pelo método EnviarMensagem do objeto GrupoMediator para cada usuário do grupo,
        //exceto o remetente da mensagem.
        public void ReceberMensagem(Mensagem mensagem)
        {
            Console.WriteLine($"{mensagem.DataEnvio} - {Nome} recebeu uma mensagem de {mensagem.Remetente.Nome}: {mensagem.Conteudo}");
        }
    }
}
