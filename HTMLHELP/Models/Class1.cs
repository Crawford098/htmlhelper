using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HTMLHELP.Models
{
    public class Formulario
    {   
        [Required(ErrorMessage ="Este campo es obligarotio")]
        public int Cedula { get; set; }//not null

        [Required(ErrorMessage = "Este campo es obligarotio")]
        public string Nombre { get; set; }//not null

        [Required(ErrorMessage = "Este campo es obligarotio")]
        public string Apellido { get; set; }//not null

        [Range(15,100,ErrorMessage = "La edad debe de ser mayor a 15 y menor de 100")]
        public int Edad { get; set; }//validar

        public int Telefono { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Este campo es obligarotio")]
        public string Correo { get; set; }//validar

        public Genero Genero { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string EstadoCivil { get; set; }

        public bool Hobbys1 { get; set; }
        public bool Hobbys2 { get; set; }
        public bool Hobbys3 { get; set; }
        public bool Hobbys4 { get; set; }



    }

    
    public enum Genero
    {
        hombre, mujer
    }
}
