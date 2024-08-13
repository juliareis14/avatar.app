using LiteDB;
using Modelos;

namespace AvatarApp.Modelos;

public class Estampador : Pessoa
{
    [BsonId]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }

}