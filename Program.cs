using System;

namespace ProjetoCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
           string nome;
           string endereco;
           string cidade;
           string localNascimento;
           string idade;
           string genero;
           string estadoCivil;
           string profissao;
           string rg;
           string cpf; 

           Console.WriteLine("Qual é o seu nome? ");                    
           nome = Console.ReadLine();
           Console.WriteLine("Qual é o seu endereço? ");                            
           endereco = Console.ReadLine();
           Console.WriteLine("Qual é o seu cidade? ");                    
           cidade = Console.ReadLine();
           Console.WriteLine("Qual é o seu localNascimento? "); 
           localNascimento = Console.ReadLine();              
           Console.WriteLine("Qual é o seu idade? "); 
           idade = Console.ReadLine();
           Console.WriteLine("Qual é o seu genero? "); 
           genero = Console.ReadLine();
           Console.WriteLine("Qual é o seu estadoCivil? "); 
           estadoCivil = Console.ReadLine();
           Console.WriteLine("Qual é o seu profissao? "); 
           profissao = Console.ReadLine();
           Console.WriteLine("Qual é o seu rg? "); 
           rg = Console.ReadLine();
           Console.WriteLine("Qual é o seu cpf? "); 
           cpf = Console.ReadLine();


           Console.Clear();


           Console.WriteLine("Nome: "+ nome);
           Console.WriteLine("endereco: "+ endereco);
           Console.WriteLine("cidade: " + cidade);
           Console.WriteLine("localNascimento: " + localNascimento);
           Console.WriteLine("idade: " + idade);
           Console.WriteLine("genero: " + genero);
           Console.WriteLine("estadoCivil: " + estadoCivil);
           Console.WriteLine("profissao: " + profissao);
           Console.WriteLine("rg: " + rg);
           Console.WriteLine("cpf: " + cpf);

        }    

        
    }
}
