namespace Modelos
{
public class CompraMp
{
    string nome;
    string telefone;
    int id;
    string materiaPrima;
    string unidade;
    decimal valor;

    Int64 id;
    public void SetNome (string nome)
    {
        this.nome= nome;
    }
    public string GetNome()
    {
        return nome;
    }


    public void SetTelefone (string telefone)
    {
        this.telefone= telefone;
    }
    public string GetTelefone()
    {
        return telefone;
    }


      public void SetId (int id)
    {
        this.id= id;
    }
    public int GetId()
    {
        return id;
    }

    
       public void SetMateriaPrima (string materiaPrima)
    {
        this.materiaPrima= materiaPrima;
    }
    public string GetMateriaPrima()
    {
        return materiaPrima;
    }

    
       public void SetUnidade (string unidade)
    {
        this.unidade= unidade;
    }
    public string GetUnidade()
    {
        return unidade;
    }


      public void SetValor (decimal valor)
    {
        this.valor= valor;
    }
    public decimal GetValor()
    {
        return valor;
    }

    
}
}