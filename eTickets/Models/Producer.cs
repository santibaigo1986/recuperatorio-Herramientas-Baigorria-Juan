﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de Perfil")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Nombre")]
        public string FullName { get; set; }
        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}