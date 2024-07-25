 namespace Modelos
{
 public class pessoa
 {
    string nome;
    string telefone;
    int id;

    public void GetNome()
    {
        return nome;
    }
    public void SetNome (string n)
    {
        nome=n;
    }

     public void GetTelefone()
    {
        return telefone;
    }
    public void SetTelefone (string t)
    {
        nome=t;
    }

     public void GetId()
    {
        return id;
    }
    public void SetId (int i)
    {
        id=i;
    }

 }
}