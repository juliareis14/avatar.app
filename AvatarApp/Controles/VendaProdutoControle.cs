using Avatarapp.Modelos;
using AvatarApp.Modelos;

namespace Controles;

public class VendaProdutoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public VendaProdutoControle() : base()
  {
    NomeDaTabela = "VendaProduto";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<VendaProduto>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<VendaProduto>? LerTodos()
  {
    var tabela = liteDB.GetCollection<VendaProduto>(NomeDaTabela);
    return new List<VendaProduto>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<VendaProduto>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(VendaProduto cliente)
  {
    var collection = liteDB.GetCollection<VendaProduto>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}