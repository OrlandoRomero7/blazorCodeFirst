using System.ComponentModel.DataAnnotations;

namespace BlazorCRUDEFCodeFirst.Models
{
    public class Book
    {

        public int BookId { get; set; }
        [Required(ErrorMessage = "Debes ingresar el titulo")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Debes ingresar el Autor")]
        public string Author { get; set; }

        [RegularExpression("^[1-9]\\d*$", ErrorMessage = "Debes indicar un numero entero y mayor a cero")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "Idicar el precio es obligatorio")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Debes ingresar una editorial")]
        public string Editorial { get; set; }
        
        public string? ImagePath { get; set; }
        
    }
}
