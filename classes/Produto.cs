namespace Listas.classes
{
    public class Produto
    {
        public int codigo { get; set; }

        public string Nome { get; set; }

        public float preco { get; set; }

        public Produto(){

        }
         public Produto(int _codigo, string _nome, float _preco)
         {
             this.codigo = _codigo;
             this.Nome = _nome;
             this.preco = _preco;

         }
        
        
        
        
        
        
    }
}