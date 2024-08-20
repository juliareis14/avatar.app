using LiteDB;

namespace AvatarApp.Modelos;

public class CadastroMp : Registro
{
    [BsonId]
    public int Id { get; set; }
    public string Tipodoproduto { get; set; }
    public Unidade Unidade { get; set; }
}

     