using OpenAI;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuvidasApp.HelpersIA
{
    public class DuvidasAIHelper
    {
        #region Atributos

        private readonly string _apiKey = "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";

        private readonly string _model = "gpt-4o-mini";


        #endregion

        #region   Métodos

        public string Executar(string pergunta)
        {
            var client = new ChatClient(

                  model: _model,
                  apiKey: _apiKey
                );

            var mensagens = new List<ChatMessage>();

            mensagens.Add(new SystemChatMessage("""

                  Você é um atendente de suporte técnico.
                  Seu objetivo é atender o usuário sobre duvidas
                  referentes a programação e ciência de dados.

                  Regras: 
            
                 -- Seja educado e objetivo e trate o usuário
                     pelo seu nome.
                 -- Seja preciso ao coletar informações
                 -- Explique os procedimentos passo a passo.
                 -- Não invente informações.
                 -- Não cometa erros.
                 -- Caso não saiba como resolver, informe que
                    o problema deverá ser encaminhado para o técnico humano.
                 -- Responda apenas dúvidas sobre suporte de informática, perguntas
                    que não tem a ver com esse tema não devem ser respondidas.
                 -- Conteudo voltado para empresarios. 


                """));

            mensagens.Add(new UserChatMessage(pergunta));
            var resultado = client.CompleteChat(mensagens);
            return resultado.Value.Content.First().Text;
        
        }



        #endregion


    }
}
