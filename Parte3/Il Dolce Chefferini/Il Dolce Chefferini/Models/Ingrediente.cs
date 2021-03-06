using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Il_Dolce_Chefferini.Models
{
    [Table("Ingrediente")]
    public class Ingrediente
    {
        public Ingrediente()
        {
            nome = "Ingrediente Default";
            comida = true;
        }

        public Ingrediente(int ID, string nom, bool comid)
        {
            id = ID;
            nome = nom;
            comida = comid;
        }

        [Key] public int id { get; set; }

        [Required] public string nome { get; set; }

        // é comida ou utensílio
        [Required] public bool comida { get; set; }
    }
}