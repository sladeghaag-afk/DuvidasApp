using DuvidasApp.Entites;
using DuvidasApp.HelpersIA;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuvidasApp.Services
{
    public class DuvidaService
    {
        public void RealizarAtendimento()
        {

            Console.WriteLine("\n BEM VINDO AO ATENDIMENTO SUPORTE DO DESCOMPLICA PROGRAMAR\n");
            var atendimento = new Duvida();
            Console.Write("INFORME O SEU NOME......: ");
            atendimento.Usuario = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("INFORME A SUA DUVIDA....: ");
            atendimento.Pergunta = Console.ReadLine() ?? string.Empty;


            var pergunta = $"""
                  
                  Responda o usuário: {atendimento.Usuario};
                  com a duvida: {atendimento.Pergunta};

                """;
             var openAiHelper = new DuvidasAIHelper();
            atendimento.Resposta = openAiHelper.Executar(pergunta);

            Console.WriteLine("\nREPOSTA:\n");
            Console.WriteLine(atendimento.Resposta);




        }






    }
}
