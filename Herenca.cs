using System;

// Classe principal
public class Produto
{
    // Atributos encapsulados
    private string nome;
    private decimal preco;
    private string descricao;
    private string categoria;

    // Construtor
    public Produto(string nome, decimal preco, string descricao, string categoria)
    {
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;

    } 
 public string Nome {
        get { return Nome; }
        set { Nome = value; } 
    }
    public decimal preco {
        get { return preco; }
        set { preco = value; }
    }
    public string descricao { 
        get { return descricao; } 
        set { descricao = value; }
    }
    public string categoria { 
        get { return categoria; } 
        set { categoria = value; }
    }
}
public class ConsoleGame : Produto { 
    private int capacidadedearmazenamento;

    public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int capacidadedearmazenamento) : base(nome, preco, descricao, categoria) {
        this.capacidadedearmazenamento = capacidadedearmazenamento;
    }


    public string CapacidadedeArmazenamento{ 
        get { return capacidadedeArmazenamento;}
        set { capacidadedeArmazenamento = value;}
    }
}

public class Jogo : Produto { 
    private string Genero;

    public Jogo(string nome, decimal preco, string descricao, string categoria, string genero) : base(nome, preco, descricao, categoria) {
        this.genero = genero;
    }


    public string Genero{ 
        get { return genero;}
        set { genero = value;}
    }
}

public class Acessorio : Produto { 
    private string tipo;

    public Acessorio (string nome, decimal preco, string descricao, string categoria, string tipo) : base(nome, preco, descricao, categoria) {
        this.tipo = tipo;
    }


    public string Tipo{ 
        get { return tipo;}
        set { tipo = value;}
    }
}


public class Colecionavel : Produto { 
    private bool edicaoLimitada;

    public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada) : base(nome, preco, descricao, categoria) {
        this.edicaoLimitada = edicaoLimitada;
    }


    public string EdicaoLimitada{ 
        get { return edicaoLimitada;}
        set { edicaoLimitada = value;}
    }
}

public class Program {
    public static void main (String [] args)

    Produto produto;
    produto = new ConsoleGame("PlayStation 5", 5.900,"Console de Vídeos Game Playsataion 5 Slim com 1 Tera de armazenamento", "Console", 1024000);

    Jogo jogo = new Jogo("Marvel's Spider-Man 2 PREMIUM"M, 299.9, "Jogo completo Marvel's Spider-Man 2 para PS5." , "Jogo PS5", "Ação e Aventura");

   Acessorio acessorio = new Acessorio("fone de ouvido", 2000, "ouvir música", "caro", "onix");

   Colecionavel colecionavel= new Colecionavel ("carro do coringa", 10000, "carro colecionavel", "idoso", true );

    
} 