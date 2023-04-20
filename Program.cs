using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Representa o grupo em si
            GrupoMediator grupo = new GrupoMediator();

            //colocando os integrantes no grupo
            IntegranteGrupo alice = new IntegranteGrupo("Alice", grupo);
            IntegranteGrupo bob = new IntegranteGrupo("Bob", grupo);
            IntegranteGrupo charlie = new IntegranteGrupo("Charlie", grupo);

            //integrantes enviando uma mensagem

            alice.EnviarMensagem("Olá, pessoal!");

        }
    }
}

/**
 * Sem o uso do padrão mediator, cada usuário teria que manter uma lista de todos os outros usuários
 * do grupo para poder enviar mensagens para eles. Isso aumentaria a complexidade do código e tornaria
 * mais difícil a manutenção e a extensão do sistema.
 * 
 * Além disso, se um usuário quisesse sair do grupo, todos os outros usuários teriam que ser
 * notificados para removê-lo de suas listas, o que seria um processo complexo e propenso a erros.
 * 
 * Usando o padrão mediator, os usuários não precisam se preocupar com a comunicação direta uns
 * com os outros, e sim com a comunicação com o mediador, que cuida de enviar as mensagens para
 * todos os usuários do grupo. Isso torna o código mais organizado, mais fácil de entender
 * e mais fácil de manter e extender no futuro.
 * 
**/