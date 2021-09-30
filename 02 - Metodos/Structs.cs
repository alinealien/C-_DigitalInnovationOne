/* As Structs são estruturas de dados que podem conter membros de dados 
e membros de ação, mas, diferente das classes, as structs são tipos de valor
e não requerem alocação do heap(Que é a referencia no outro local na memoria 
onde esta o objeto).

Uma variavel dce um tipo de struct armazena diretamente os dados da estrutura, 
enquanto uma variavel de um tipo de classe armazena uma referencia a um objeto 
alocado na memoria.

Structs não aceita herança determinada pelo desenvolvedor.

São uteis para pequenas struturas de dados que possuem semantica 
de valor: numeros complexos,pontos em um sistema de coordenadas ou pares
de chave-valor em um dicionario sao bons exemplos de utilização.

O uso de structs em vez de classes para pequeunas estruturas de dados pode
fazer uma grande diferença no numero de alocações de memoria.
 
 EX:

 public struct Ponto
 {
     public int x, y;
     public Ponto(int x, int y)
     {
         this.x = x;
         this.y = y;
     }
 }
....................

Construtores de structs são chamados com o operados new, semelhante a 
um construtor de classe, mas em vez de alocar dinamicamente um objeto
no heap gerenciado e retornar uma referencia a ele, um construtor struct simplesmente retorna
retorna o próprio valor struct(normalmente em um local temporario no stack), e esse valor
é copiado conforme necessario.

................. Interfaces .....................
 Uma interface define um contato que pode ser implementado por classe e structs.

 Uma interface pode conter metodos, propriedades, eventos e indexadores.

Uma interface não fornce implementações dos menbros que define - apenas
"assinaturas".

As interfaces podem empregrar herança multipla.

EX_I:

  interface IControl (Quem implementar o IControl tem que ter o metodo void Paint)
  {
      void Paint(); 
  }
  interface IListbox
  { (Quem implementar o IListbox tem que ter o metodo void SetText(string text))
      void SetText(string text);
  }
  interface IComboBox: ITextBox: IListBox {}
  (Quem implementar o IComboBox tem que ter o metodo ITextBox e IListBox)

EX_II

interface IDataBound
{
    void Bind(Binder b);
}  

public class EditBox: IComboBox, IDataBound
{
    public void Paint() {}
    public void SetText(string text) {}
    public void Bind(Bind b) {}
}

................ Enums ....................
Um enum é um tipo de valor distinto com um conjunto de constantes nomeadas.

Você define enumeracoes quando precisa definir um tipo que pode ter um conjunto
de valores discretos. eles usam um dos tipos de valor integral como armazenamento
subjacente. Eles fornecem significado semântico aos valores discretos.

EX_I

enum Cor {
    
    Vermelho,
    Verde,
    Azul
}

static void EscreverCor(Cor, Cor)
{
    switch (cor)
    {
        case. Cor.Vermelho:
        Console.WriteLine("Vermelho);
        break;

        case Color.Verde:
        Console.WriteLine("Verde");
        break;
    }
}

Cada tipo de enum possui um tipo integral correspondente 
chamado tipo subjacente do tipo de enum.

Um tipo de enumeracao que nao declara explicitamente um tipo subjacente
tem um tipo subjacente int.

EX_II

enum Alinhamento: sbyte
{
    Esquerda = -1,
    Centro = 0,
    Direita = 1
    
}

*/