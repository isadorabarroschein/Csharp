using System;
//INterface representando um ataque
interface IAtacante {
    void Atacar();
}
public abstract class Heroi
{
    //Atributos da classe Heroi
    private string nome;
    private double vida;
    private string forca;
    private string agilidade;

    //Construto da classe Heroi
    public Heroi ( string nome, double vida, string forca, string agilidade) 
    {
        this.nome = nome;
        this.vida = vida;
        this.forca = forca;
        this.agilidade = agilidade;
    }
     // Getter para o nome Heroi
    public string GetNome(){
        return nome;
    }
    // Seter para o nome 
    public void SetNome(string nome){
        this.nome = nome;
    }
     // Getter para o vida
    public double GetVida(){
        return vida;
    }
    // Seter para o vida
    public void SetVida(double vida){
        this.vida = vida;
    }
     // Getter para o força
    public string GetForca(){
        return forca;
    }
    // Seter para o força
    public void SetForca(string forca){
        this.forca = forca;
    }
     // Getter para o agilidade
    public string GetAgilidade(){
        return agilidade;
    }
    // Seter para o agilidade
    public void SetAgilidade(string agilidade){
        this.agilidade = aligilidade;
    }
    public abstract void Especial(); //Método abstrato   
}
// Classe Guerreiro implementando a interface IAtaque
class Guerreiro : IAtacante, Heroi {
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");
    }
    public override void Especial()
    {
        Console.WriteLine("Guerreiro ataca com golpe especial")
    }

}
// Classe Mago implementando a interface IAtaque
class Mago : IAtacante, Heroi {
    public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo");
    }
    public override void Especial()
    {
        Console.WriteLine("Mago ataca com golpe especial")
    }
}
//Classe Arqueiro implementando a interface IAtacante, Heroi
class Arqueiro : IAtacante, Heroi {
    public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas!");
    }
    public override void Especial()
    {
        Console.WriteLine("Arqueiro ataca com golpe especial")
    }
}
class Program {
    static void Main(string[] args) {
        //Criando instâncias de diferentes personagens
        Guerreiro guerreiro = new Guerreiro();
        Mago mago = new Mago();
        Arqueiro arqueiro = new Arqueiro();

        //Chamando o método Atacar de cada personagem
        guerreiro.Atacar();
        guerreiro.Especial();

        mago.Atacar();
        mago.Especial();

        arqueiro.Atacar();
        arqueiro.Especial();
    }
}
