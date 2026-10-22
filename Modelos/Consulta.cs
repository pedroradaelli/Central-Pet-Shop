using Alura.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1.Modelos
{
    

    internal class Consulta
    {
        //Lista que armazena todas as consultas
        public static List<Consulta> ListaConsulta = new();

        public Dono DonoPet;
        public Pet NomePet;
        public string Motivo;

        //Construtor da classe, usa outra Classes do projeto
        public Consulta(Dono dono, Pet nome, string motivo)
        {
           DonoPet = dono;
           NomePet = nome;
           Motivo = motivo;

        }

        //Função que usa as classes Dono e Pet para criar uma nova consulta
        public static void NovaConsulta(Dono dono, Pet nome, string motivo)
        {
            Consulta novaConsulta = new(dono, nome, motivo);
            ListaConsulta.Add(novaConsulta);
            
        }


        //Usa um foreach para ver consultas registradas
        public static void VerificaConsulta()
        {
            Console.WriteLine("Consultas registradas: ");

            foreach (Consulta c in ListaConsulta)
            {
                Console.WriteLine($"\nDono: {c.DonoPet.DonoPet}");
                Console.WriteLine($"Pet: {c.NomePet.NomePet}, {c.NomePet.RacaPet}");
                Console.WriteLine($"Motivo da consulta: {c.Motivo}");

            }
        }

    }
}
