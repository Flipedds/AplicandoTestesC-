using Classes;

namespace tests;

// Cenário de testes User
public class UserTest
{
    /*  Um usuário só pode ser criado se os argumentos para sua criação
    seguirem os padrões pre-estabelecidos ??*/
    [Fact]
    public void CriandoUserValido()
    {
        //arrange
        string nome = "Peter";
        int idade = 22;

        //assert
        Assert.IsNotType<ArgumentException>(new User(nome, idade));
    }

    [Fact]
    public void CriandoUserComNomeInvalido()
    {
        //arrange
        string nome = "";
        int idade = 19;

        //assert
        Assert.ThrowsAny<ArgumentException>(() => new User(nome, idade));
    }

    [Fact]
    public void CriandoUserComIdadeInvalida()
    {
        //arrange
        string nome = "Filipe";
        int idade = -1;

        //assert
        Assert.ThrowsAny<ArgumentException>(() => new User(nome, idade));
    }

    [Fact]
    public void CriandoUserComNomeEIdadeInvalidos()
    {
        //arrange
        string nome = "";
        int idade = -1;

        //assert
        Assert.ThrowsAny<ArgumentException>(() => new User(nome, idade));
    }

    // User ToString() retorna corretamente os dados ??
    [Fact]
    public void UserToStringRetornaCorretamente()
    {
        // arrange
        string nome = "John";
        int idade = 32;

        //assert
        User user_john = new(nome, idade);
        Assert.Equal($"Nome: {nome}, Idade: {idade}", user_john.ToString());
    }

    // Propriedades corretas ?
    [Theory]
    [InlineData("peter", 23)]
    [InlineData("john", 25)]
    [InlineData("gab", 19)]
    public void VerificarSeAsPropriedadesDeUserCorrespondem(string nome, int idade)
    {
        User user = new(nome, idade);
        Assert.Equal(nome, user.Nome);
        Assert.Equal(idade, user.Idade);
    }
}
