using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWeb.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Column("contatoId")]
        [Display(Name = "ContatoId")]
        public int ContatoId { get; set; }

        [Column("assuntoId")]
        [Display(Name = "Assunto")]
        public int AssuntoId { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("email")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Por favor, insira um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Column("telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        //[Column("empresa")]
        //[Display(Name = "Empresa")]
        //public string Empresa { get; set; }

        [Column("mensagem")]
        [Display(Name = "No que podemos ajudar ?")]
        public string Mensagem { get; set; }

        [Column("dataEnvio")]
        public DateTime DataEnvio { get; set; }

        [NotMapped]
        public List<SelectListItem> ListaContato{ get; set; }

        public Contato()
        {
            ListaContato = new List<SelectListItem>();
        }
    }
}