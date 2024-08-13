using LiteDB;

namespace AvatarApp.Modelos;

    public class Pedido 
 {
    [BsonId]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Produto { get; set; }
        public string Unidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public decimal Total { get; set; }
        public string Prazo { get; set; }
 }
       