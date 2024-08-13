using LiteDB;

namespace AvatarApp.Modelos;

    public class Estoque
 {
    [BsonId]
    public int Id { get; set; }
    public string MateriaPrima { get; set; }
    public string Quantidade { get; set; }
    public string Entrada { get; set; }
    public int Fornecedor { get; set; }
 }
     

    