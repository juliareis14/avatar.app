using LiteDB;

namespace AvatarApp.Modelos;

public class VendaProduto : Registro
 {
    [BsonId]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Produto { get; set; }
    public string Unidade { get; set; }
 }
      