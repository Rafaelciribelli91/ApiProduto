using System.ComponentModel.DataAnnotations;

namespace API_Produto.Models
{    
    public class Produto
    {
        [Key]

        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Digite o nome do produto")]
        [StringLength(50, ErrorMessage = "Nome não pode ter mais que 50 caracteres")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Digite o preço do produto")]
        [Range(0.1, 999.99)]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Digite a descrição do Produto")]
        [StringLength(180, ErrorMessage = "A descrição é de no maximo 180 caracteres")]
        public string DescricaoProduto { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
