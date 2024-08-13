using Avatarapp.Modelos;
using LiteDB;

namespace AvatarApp.Modelos;

public class CompraMp : Registro
{
    [BsonId]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string MateriaPrima { get; set; }
    public string Unidade { get; set; }
    public decimal Valor { get; set; }

}