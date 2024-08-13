using LiteDB;

namespace Avatarapp.Modelos;
    public class Produto
 { 
    [BsonId]
    public int Id { get; set; }
    public string tipodoproduto { get; set; }
    public string unidade { get; set; }
    public string cor { get; set; }
    public string tecido { get; set; }
    public string marca { get; set; }
 }
    


    