using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExemploWebAppMVC.Modelos
{
    [Table("Times")]
    public class Times
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataFundacao { get; set; }

        public string Estado { get; set; }

        public string NomeEstadio { get; set; }
    }
}
