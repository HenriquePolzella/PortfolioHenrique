using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWeb.Models
{
    [Table("Assunto")]
    public class Assunto
    {
        [Column("assuntoId")]
        [Display(Name = "Numero Cadastro")]
        public int AssuntoId{ get; set; }

        [Column("assunto")]
        [Display(Name = "Assunto")]
        public string assunto { get; set; }


        [NotMapped]
        public List<SelectListItem> ListaAssunto { get; set; }

        public Assunto()
        {
            ListaAssunto = new List<SelectListItem>();
        }
    }
}

