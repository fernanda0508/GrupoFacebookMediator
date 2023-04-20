using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoFacebook
{
    //A classe Mensagem representa uma mensagem enviada por um usuário do grupo e tem
    //três propriedades: Conteudo, Remetente e DataEnvio
    public class Mensagem
    {
        //Conteudo armazena o conteúdo da mensagem
        public string Conteudo { get; set; }
        //Remetente armazena uma referência ao objeto IntegranteGrupo que enviou a mensagem
        public IntegranteGrupo Remetente { get; set; }
        //DataEnvio armazena a data e hora em que a mensagem foi enviada.
        public DateTime DataEnvio { get; set; }

        public Mensagem(string conteudo, IntegranteGrupo remetente)
        {
            Conteudo = conteudo;
            Remetente = remetente;
            DataEnvio = DateTime.Now;
        }
    }
}
