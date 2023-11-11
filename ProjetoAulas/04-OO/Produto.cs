namespace Cadastro;

// public - visibilidade de classes/atributos/métodos
// class - tipo de estrutura
// Produto - nome da classe
public class Produto
{
    private int Id;

    public readonly int Estoque;
    public string Descricao { get; set; }

    public Produto()
    {
        Estoque = 1;
    }

    public void ImprimirDescricao()
    {
        Console.WriteLine(GetId() + " - " + Descricao + " - " + Estoque);
    }

    public void SetId(int id)
    {
        Id = id;
    }

    public int GetId()
    {
        return Id;
    }

}

public class Pessoa
{
    public int Id { get; set; }
    public string Endereco { get; set; }

    public string Cidade { get; set; }
    public string CEP { get; set; }

    public virtual void ImprimirDados()
    {
        Console.WriteLine("Código  : " + Id);
        Console.WriteLine("Endereco: " + Endereco);
        Console.WriteLine("Cidade  : " + Cidade);
        Console.WriteLine("CEP     : " + CEP);

    }

}

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }

    public override void ImprimirDados()
    {
        base.ImprimirDados();
        Console.WriteLine("CPF     : " + CPF);
    }

}


public sealed class Configuracao
{
    public string Host { get; set; }
}

public abstract class Animal
{
    public string Nome { get; set; }

    public abstract string GetInformacoes();

    public void Imprimir()
    {
        Console.WriteLine("Nome         : " + Nome);
        Console.WriteLine("Innformacoes : " + GetInformacoes());
    }
}

public class Cachorro : Animal
{
    public override string GetInformacoes()
    {
        return "Cachorro é um bom amigo";
    }
}

public record Curso (int Id, string Descricao);


// É bom começar o nome de uma interface com a letra I
public interface INotificar
{
    string Descricao { get; set; }
    void Notificar();

}

public class Email : INotificar
{
    public string Descricao { get ; set; }

    public void Notificar()
    {
        Console.WriteLine("Enviando e-mail ...");
    }
}

public class Sms : INotificar
{
    public string Descricao { get; set; }

    public void Notificar()
    {
        Console.WriteLine("Enviando SMS ...");
    }
}