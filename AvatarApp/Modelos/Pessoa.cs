 namespace Modelos
{
 public class pessoa
 {
    string nome;
    string telefone;
    int id;

    public string GetNome()
    {
        return nome;
    }
    public void SetNome (string n)
    {
        nome=n;
    }

     public string GetTelefone()
    {
        return telefone;
    }
    public void SetTelefone (string t)
    {
        nome=t;
    }

     public int GetId()
    {
        return id;
    }
    public void SetId (int i)
    {
        id=i;
    }

 }
}