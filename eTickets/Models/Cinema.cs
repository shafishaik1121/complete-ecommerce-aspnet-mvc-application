using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Logo is Required")]
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }


        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 Characters")]
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Discription is Required")]
        [Display(Name = "Discription")]
        public string Description { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}
