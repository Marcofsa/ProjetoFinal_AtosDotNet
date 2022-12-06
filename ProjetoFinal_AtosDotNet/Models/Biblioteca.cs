using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal_AtosDotNet.Models
{
    [Table ("TBiblioteca")]
    public class Biblioteca
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column("Plataforma")]
        [Display(Name = "Plataforma")]
        public string plataforma { get; set; }



    }
}
