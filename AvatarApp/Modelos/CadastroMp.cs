using LiteDB;

namespace AvatarApp.Modelos;

public class CadastroMp
{
    [BsonId]
    public int Id { get; set; }
    public string Tipodoproduto { get; set; }
    public string Unidade { get; set; }
}

     