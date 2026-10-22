🐾 Central Pet Shop

Aplicação de console em C# para registrar consultas de um pet shop.

  Funcionalidades
  
Registrar consulta (dono, pet, raça e motivo)
1. Ver médicos disponíveis
2. Ver donos registrados
3. Ver pets registrados
4. Ver consultas registradas
   
   Estrutura
   
Program.cs: menu e fluxo principal
Dono.cs, Pet.cs, Medico.cs: classes com suas listas
Consulta.cs: junta um Dono, um Pet e o motivo da consulta
Como executar

Requer .NET 6+.

bash
dotnet run

Os dados ficam apenas na memória e são perdidos ao fechar o programa.
