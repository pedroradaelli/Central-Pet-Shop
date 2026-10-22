using Alura.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Modelos
{
    internal class Dono
    {
        //Lista que armazena o nome dos donos
        public static List<Dono> ListaDono = new();
        public string DonoPet;

        //construtor da classe
        public Dono(string dono)
        {
            DonoPet = dono;
        }

        //Função que adiciona um novo Dono com base no que o usuario digita
        public static Dono RegistraDono(string dono)
        {
            Dono novoDono = new(dono);
            ListaDono.Add(novoDono);
            return novoDono;
        }

        //Usa um foreach para ver os donos registrados
        public static void ExibeDono()
        {
            foreach (Dono d in ListaDono)
            {
                Console.WriteLine(d.DonoPet);

            }
        }
    }
}
