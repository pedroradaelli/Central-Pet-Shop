using ConsoleApp1.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Modelos
{
    internal class Medico
    {
        //Lista que armazena os medicos
        public static List<Medico> ListaMedico = new()
        {
            new Medico("Pablo"),
            new Medico("João"),
            new Medico("Marcelo")
        };

        public string Nome;

        //Construtor da clase
        public Medico(string nome)
        {
            Nome = nome;
        }
        
        //Usa um foreach para exibir os medicos regsitrados
        public static void ExibeMedico()
        {
            foreach(Medico m in ListaMedico)
            {
                Console.WriteLine(m.Nome);
            }
        }

    }
}
