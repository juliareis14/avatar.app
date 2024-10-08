using Avatarapp.Modelos;
using LiteDB;

namespace AvatarApp.Modelos;

    public class Corte : Registro
 {     
     [BsonId]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Produto Produto { get; set; }
        public string Prazo { get; set; }
        public string Quantidade { get; set; }
        public string Entrada { get; set; }
        public string Cor { get; set; }
 }

        