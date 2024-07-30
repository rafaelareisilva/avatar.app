namespace avatarapp.Modelos;
public class Pessoa
{
    string nome;
    string telefone;
    int id;
         
public string GetNome ()
{
    return nome;
}
public void SetNome (string n)
{
    nome=n;
}

public string GetTelefone ()
{
    return telefone;
}
public void SetTelefone (string t)
{
    telefone=t;
}

public int GetId ()
{
    return id;
}
public void SetTelefone (int i)
{
    id=i;
}
}
}