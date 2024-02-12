using System;
using CSharpShellCore;
namespace SorteioDeEntretenimento{
class Classe{
public static void Main(String[] args){


try{
Console.WriteLine("seja bem vindo a aplicação que sorteia entrenimento");
Console.WriteLine("escolha uma entre as opçōes abaixo: ");
Console.WriteLine("(1) jogo");
Console.WriteLine("(2) anime");
Console.WriteLine("(3) filme/serie");
Console.WriteLine("(4) outro");
string op = Console.ReadLine();
Random random = new Random();

if(op == "1")
{
Console.WriteLine("insira é o nome da sua primeira opçāo de jogo: ");
string esc1 = Console.ReadLine();

Console.WriteLine("insira o nome da sua segunda opçāo de jogo: ");
string esc2 = Console.ReadLine();

Console.WriteLine("insira é o nome da sua terceira opçāo de jogo: ");
string esc3 = Console.ReadLine();

Console.WriteLine("insira é o nome da sua quarta opçāo de jogo: ");
string esc4 = Console.ReadLine();


int sorte = random.Next(0,4);
Console.WriteLine("escolha a "+sorte+"° opçāo");

}

if(op == "2")
{
    
Console.WriteLine("insira é o nome da sua primeira opçāo de anime: ");
string esc1 = Console.ReadLine();

Console.WriteLine("insira é o nome da sua segunda opçāo de anime: ");
string esc2 = Console.ReadLine();

Console.WriteLine("insira é o nome da sua terceira opçāo de anime: ");
string esc3 = Console.ReadLine();

Console.WriteLine("insira é o nome da sua quarta opçāo de anime: ");
string esc4 = Console.ReadLine();

int sorte = random.Next(0,4);
Console.WriteLine("escolha a "+sorte+"° opçāo");

}

if(op == "3")
{
    
Console.WriteLine("insira  o nome da sua primeira opçāo de série/filme: ");
string esc1 = Console.ReadLine();

Console.WriteLine("insira  o nome da sua segunda opção de série opçāo de série/filme: ");
string esc2 = Console.ReadLine();

Console.WriteLine("insira  o nome da sua terceira opção de série opçāo de série/filme: ");
string esc3 = Console.ReadLine();

Console.WriteLine("insira  o nome da sua quarta opção de série opçāo de série/filme: ");
string esc4 = Console.ReadLine();

int sorte = random.Next(0,4);
Console.WriteLine("escolha a "+sorte+"° opçāo");

}

if(op == "4")
{

Console.WriteLine("insira o nome da primeira opção de conteúdo que você deseja consumir:  ");
string esc1 = Console.ReadLine();

Console.WriteLine("insira o nome da segunda opção de conteúdo que você deseja consumir:  ");
string esc2 = Console.ReadLine();

Console.WriteLine("insira o nome da terceira opção de conteúdo que você deseja consumir:  ");
string esc3 = Console.ReadLine();

Console.WriteLine("insira o nome da quarta opção de conteúdo que você deseja consumir:  ");
string  esc4 = Console.ReadLine();

int sorte = random.Next(0,4);
Console.WriteLine("escolha a "+sorte+"° opçāo");



}
}
catch(Exception e){

}
finally{
Console.WriteLine("opçāo inválida, tente novamente");
}



}
}
}

