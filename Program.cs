using Alura.Modelos;
using ConsoleApp1.Modelos;



void ExibeMenu() 
{
Console.WriteLine("1 - Registrar Consulta");

Console.WriteLine("2 - Verificar medicos Disponiveis");

Console.WriteLine("3 - Verificar donos registrados");

Console.WriteLine("4 - Verificar Pets registrados");

Console.WriteLine("5 - Consultas registradas");
string Escolha = Console.ReadLine()!;
int EscolhaNumerica = int.Parse(Escolha);

switch(EscolhaNumerica)
{
    case 1: RegistraConsulta();
        break;
    case 2: VerificaMedico();
        break;
    case 3: VerificaDono();
         break;
     case 4: VerificaPet();
        break;
    case 5: VerificaConsulta();
         break;
    default: Console.WriteLine("n");
        break;
}

}



void RegistraConsulta()
{
    //Inicia a função limpando terminal e pedindo o nome do usuario e registrando ele na classe Dono
    Console.Clear();
    Console.WriteLine("Por qual nome iremos te chamar: ");
    string NomeDono = Console.ReadLine()!;

    Console.Clear();
    
    Dono dono = Dono.RegistraDono(NomeDono);
    Console.WriteLine("Seu Nome foi registrado com sucesso!");

    //Continua a função agora pedindo o nome e raça do pet e registrando na classe Pet
    Console.Clear();

    Console.WriteLine("Qual nome do seu pet: ");
    string NomePet = Console.ReadLine()!;
    
    

    Console.WriteLine("Qual a raça do seu pet: ");
    string RacaPet = Console.ReadLine()!;
    Pet pet = Pet.RegistraPet(NomePet, RacaPet);

    //Continua a função registrando o motivo da consulta na classe Consulta
    //A classe Consulta rece as classes Dono e Pet para registrar a consulta
    Console.Clear();

    Console.WriteLine("Qual o motivo de sua consulta: ");
    string MotivoConsulta = Console.ReadLine()!;
    Consulta.NovaConsulta(dono, pet, MotivoConsulta);

    Voltar();
    
    
}

//Usa um foreach na classe Consulta para ver as consultas registradas (não terminado)
void VerificaConsulta()
{
    Console.Clear();
    
    Consulta.VerificaConsulta();

    Voltar();
}

//Usa um foreach na classe Medico para ver os medicos disponives (não terminada)
void VerificaMedico()
{
    Console.Clear();

    Console.WriteLine("Os médicos disponiveis no momento são: ");
    Medico.ExibeMedico();

    Voltar();
}


//Usa um foreach na classe Dono para ver os donos disponives
void VerificaDono()
{
    Console.Clear();
    Console.WriteLine("Todos os donos registrados: ");
    Dono.ExibeDono();

    Voltar();
}


//Usa um foreach na classe Pet para ver os pets disponives
void VerificaPet()
{
    Console.Clear();

    Console.WriteLine("Todos os pets registrados: ");
    Pet.ExibePet();

    Voltar();
}



ExibeMenu();

//Essa função exibe a mensagem final que está presente em todas as outras funções do código
void Voltar()
{
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibeMenu();
}