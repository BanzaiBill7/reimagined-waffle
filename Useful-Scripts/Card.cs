
//Esse Statement serve para criar menus na parte de Assets da Unity
[CreateAssetMenu(fileName = "Nome Dos Arquivos Padrao", menuName = "Nome Do Menu")]
//Nessa parte, se quiser sub-menus deve escrever (menuName = "NomedoMenu/SubMenu/SubMenu2/Submenu3").


//Estrutura do Scriptable Object (como abrir).
public class NOMEDOSCRIPT : DERIVADODE?
{
  //"public" pois pode ser acessado de todos os métodos e classes
  //nome do script deve ser o nome do arquivo .cs
  //"DERIVADODE?" se for MonoBehaviour ele deve ser vinculado a um Objeto, para ter propriedades. Porém,
  //nesse caso queremos que ele seja "independente", e consiga armazenar informações sem necessidade de estar vinculado
  //a um Game Object. Então usamos "ScriptableObject" que é o tipo do objeto em questão.
 
  public string name; //todo objeto já vem com uma variável chamada nome, portanto é necessário usar o statement "new", para
  //que ele esse variável criada seja usada no lugar do original, ou mudar o nome para cardName; por exemplo.
  public string description;
  
  public Sprite artwork;
  
  public int manaCost;
  public int attack;
  public int health;

  public void Print () //Esse é um método para mostrar informações sobre esse Scriptable Object, que vai ser chamado no CardDisplay
  {
  Debug.Log(name + ":" + description + "This card costs: " + manaCost);
  }
}

//Exemplo - Fazendo uma carta de TCG ou Online Card Game(onde o nome do arquivo é "Card"):

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject
{
  public string name; 
  public string description;
  
  public Sprite artwork;
  
  public int manaCost;
  public int attack;
  public int health;
  
  public void Print () 
  {
  
  }
}
