using System;

// Classe principal
public class Pessoa
{
    // Atributos encapsulados
    private string nome;
    private int idade;

    // Construtor
    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    // Métodos públicos para acessar e modificar os atributos encapsulados
    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string novoNome)
    {
        nome = novoNome;
    }

    public int GetIdade()
    {
        return idade;
    }

    public void SetIdade(int novaIdade)
    {
        idade = novaIdade;
    }

    public void Andar()
    {
        Console.WriteLine("Pessoa andando");
    }
}

// Classe que herda da classe Pessoa
public class Estudante : Pessoa
{
    // Construtor
    public Estudante(string nome, int idade) : base(nome, idade)
    {
    }

    // Implementação do método Andar para Estudante
    public void Andar()
    {
        Console.WriteLine("Estudante andando");
    }
}

// Classe que herda da classe Pessoa
public class Professor : Pessoa
{
    // Construtor
    public Professor(string nome, int idade) : base(nome, idade)
    {
    }

    // Implementação de métodos específicos para Professor, se necessário
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciando objetos da classe Pessoa
        Professor professor = new Professor("João", 30);

        // Chamando método Andar da classe Pessoa
        professor.Andar();

        // Instanciando objeto da classe Estudante
        Estudante estudante1 = new Estudante("Maria", 25);

        // Chamando método Andar da classe Estudante
        estudante1.Andar();
    }
}