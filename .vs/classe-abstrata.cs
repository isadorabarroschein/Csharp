using System;

public abstract class Veiculo
{
    //Atributos da classe Veiculo
    private string nome;
    private double motor;
    private string modelo;
    private string cor;

    //Construto da classe Veiculo 
    public Veiculo ( string nome, double motor, string modelo, string cor) 
    {
        this.nome = nome;
        this.motor = motor;
        this.modelo = modelo;
        this.cor = cor;
    }
     // Getter para o nome
    public string GetNome(){
        return nome;
    }
    // Seter para o nome 
    public void SetNome(string nome){
        this.nome = nome;
    }
     // Getter para o motor
    public double GetMotor(){
        return motor;
    }
    // Seter para o motor 
    public void SetMotor(double motor){
        this.motor = motor;
    }
     // Getter para o modelo
    public string GetModelo(){
        return modelo;
    }
    // Seter para o modelo
    public void SetModelo(string modelo){
        this.modelo = modelo;
    }
     // Getter para o cor
    public string GetCor(){
        return cor;
    }
    // Seter para o cor 
    public void SetCor(string cor){
        this.cor = cor;
    }
    public abstract void Mover(); //Método abstrato
    public abstract void Ligar(); //Método abstrato
    public abstract void Desligar(); //Método abstrato
    public abstract void Freiar(); //Método abstrato    
}

public class Carro : Veiculo {
    private bool guidao;
    public Carro(string nome, double motor, string modelo, string cor, bool volante) : base(nome, motor, modelo, cor){
        this.volante = volante
    }
    public string GetVolante(){
        return volante;
    }
    // Seter para o cor 
    public void SetVolante(bool volante){
        this.volante = volante;
    }
    public abstract void Mover(){
        Console.WriteLine($"{GetNome()} moveu!");   
    }
    public abstract void Ligar(){
        Console.WriteLine($"{GetNome()} ligou!");   
    }
    public abstract void Desligar(){
        Console.WriteLine($"{GetNome()} desligou!");   
    }
    public abstract void Freiar(){
        Console.WriteLine($"{GetNome()} parou!");   
    } 
}
public class Moto : Veiculo {
    private bool guidao;
    public Moto(string nome, double motor, string modelo, string cor, bool guidao) : base(nome, motor, modelo, cor){
        this.guidao = guidao
    }
    public string GetGuidao(){
        return guidao;
    }
    // Seter para o cor 
    public void SetGuidao(bool guidao){
        this.guidao = guidao;
    }
    public abstract void Mover(){
        Console.WriteLine($"{GetNome()} moveu!");   
    }
    public abstract void Ligar(){
        Console.WriteLine($"{GetNome()} ligou!");   
    }
    public abstract void Desligar(){
        Console.WriteLine($"{GetNome()} desligou!");   
    }
    public abstract void Freiar(){
        Console.WriteLine($"{GetNome()} parou!");   
    } 
}
class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro("opala", 4.0, 2000, "marrom", true);
        carro.Ligar();
        carro.Mover();
        carro.Freiar();
        carro.Desligar();

        Moto moto = new Moto("harley", 300, 2024, "preta", true);
        moto.Ligar();
        moto.Mover();
        moto.Freiar();
        moto.Desligar();           

    }
}