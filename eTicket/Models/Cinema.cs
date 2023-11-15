using System.ComponentModel.DataAnnotations;
using eTicket.Data.Base;

namespace eTicket.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Cinema Description")]
        public string Description { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}