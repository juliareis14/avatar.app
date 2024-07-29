namespace Modelos
{
    public class Estoque 
 {
    string materiaPrima;
    string quantidade;
    string entrada;
    int fornecedor;
    int id;
     Int64 id;

    public void SetMateriaPrima (string materiaPrima)
    {
        this.materiaPrima= materiaPrima;
    }
    public string GetMateriaPrima()
    {
        return materiaPrima;
    }

     public void SetQuantidade (string quantidade)
    {
        this.quantidade= quantidade;
    }
    public string GetQuantidade()
    {
        return quantidade;
    }

     public void SetEntrada (string entrada)
    {
        this.entrada= entrada;
    }
    public string GetEntrada()
    {
        return entrada;
    }

     public void SetFornecedor (int fornecedor)
    {
        this.fornecedor= fornecedor;
    }
    public int GetFornecedor()
    {
        return idfornecedor;
    }

     public void SetId (int id)
    {
        this.id= id;
    }
    public int GetId()
    {
        return id;
    }
        
 }

}       