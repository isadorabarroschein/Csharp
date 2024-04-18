public class Produto
{
    // Atributos encapsulados
    private string nome;
    private decimal preco;
    private string descricao;
    private string categoria;

    public virtual void Promocao(){
        Console.WriteLine("promoção de 50% de desconto")
    }


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

    public override void Promocao(){
        Console.WriteLine("promoção do playstation")
    }
}