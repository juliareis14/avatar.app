
using Avatarapp.Modelos;
using AvatarApp.Modelos;

namespace Controles;

public class CadastroMpControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CadastroMpControle() : base()
  {
    NomeDaTabela = "Clientes";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<CadastroMp>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<CadastroMp>? LerTodos()
  {
    var tabela = liteDB.GetCollection<CadastroMp>(NomeDaTabela);
    return new List<CadastroMp>(tabela.FindAll().OrderBy(d => d.Sobrenome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<CadastroMp>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(CadastroMp cliente)
  {
    var collection = liteDB.GetCollection<CadastroMp>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}