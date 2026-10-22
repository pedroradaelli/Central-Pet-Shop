using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Modelos
{
    internal class Pet
    {
        //Lista que armazena o nome dos pets
        public static List<Pet> ListaPet = new();

        public string NomePet;
        public string RacaPet;

        //construtor da classe
        public Pet(string nomePet, string raca)
        {
            NomePet = nomePet;
            RacaPet = raca;
        }

        //Adiciona um novo Pet com base no que o usuario digita
        public static Pet RegistraPet(string pet, string raca)
        {
            
            Pet novoPet = new(pet, raca);
            ListaPet.Add(novoPet);
            return novoPet;
        }

        //Usa um foreach para ver os pets registrados
        public static void ExibePet()
        {
            foreach(Pet p in ListaPet) 
            {
                Console.WriteLine(p.NomePet);
            }
        }
    }
}
