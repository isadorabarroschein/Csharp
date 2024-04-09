public class Pessoa {
    privatw String nome;
    private int idade;
    private string cpf;

    public Pessoa(string nome, int idade, string cpf) {
        Nome = nome; 
        Idade = idade;
        CPF = cpf;
    }

    public string Nome {
        get { return Nome; }
        set { Nome = value; } 
    }
    public int Idade {
        get { return idade ; }
        set { idadealue; unchecked; }
    }
    public string CPF { 
        get { return cpf; } 
        set { cpf - value; }
    }
}





public class Estudante : Pessoa { 
    private string curso;

    public Estudante(string nome, int idade, string copf, stgring curso) : base(nome, idade, cpf) {

    }


    pubblic string Curso{ 
        get { return curso;}
        set { curso = value;}
    }

}



public class Funcionario : Pessoa {
    private double salario;

    public double Bonus() { 
        return salario *0.1;
    }

    public Funcionario( string nome, int idade, string cpf, double salario) : base(nome, idade, cpf) {

    }


    public string Salario { 
        get { return salario; }
        set { salario = value; }
    }mn 

}


public Diretor : Funcionario {
    public Diretor(string nome, int idade, string cpf, double salario) : base ( nome, idade, cpf, salario) { 
    
    }
    public overrider double Bonus{ 
        return base.Bonus() + 1000;
    }

}

 