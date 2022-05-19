using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banco.Models
{
    [Table("Cliente")]
    public class ClienteModel
    {
        [Key] //CHAVE PK
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //GERADO PELO BANCO
        public int Id { get; set; }

        [Required] //NOT NULL
        [MaxLength(80)] //QNT MAX DE CARACTERES
        [Column("Nome", TypeName = "NVARCHAR")] // NOME DA COLUNA E TIPO
        public string Nome { get; set; }

        [Required] //NOT NULL
        [MaxLength(200)] //QNT MAX DE CARACTERES
        [Column("Email", TypeName = "VARCHAR")] // NOME DA COLUNA E TIPO
        public string Email { get; set; }
    }
}