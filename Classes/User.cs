namespace Classes;

public class User
{
    public User(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    private string _nome;
    public string Nome
    {
        get { return _nome; }
        set => _nome = value != "" ? _nome = value : throw new ArgumentException("Nome inválido!");

    }

    private int _idade;
    public int Idade
    {
        get => _idade;
        set => _idade = value > 0 ? _idade = value : throw new ArgumentException("Idade inválida!");
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}
