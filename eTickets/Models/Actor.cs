using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de Perfil")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Nombre")]
        public string FullName { get; set; }
        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        //Relaciones
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}