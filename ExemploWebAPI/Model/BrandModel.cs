using System.ComponentModel.DataAnnotations.Schema;

namespace ExemploWebAPI.Model
{
    [Table("Brand")]
    public class BrandModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
    }
}
