using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalDotNet.Models
{
    [Table("Biblioteca")]

    public class Biblioteca
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Plataforma")]
        [Display(Name = "Plataforma")]
        public string Plataforma { get; set;}

        [Column("Categoria")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public string Descrição { get; set;}
    }
}
