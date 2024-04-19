using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ProjetPfa.ModelView
{
    public class ServiceAddVM
    {
        [Required(ErrorMessage = "Le libellé du service est requis")]
        public string Libelle { get; set; }

        [Required(ErrorMessage = "La description du service est requise")]
        public string Description { get; set; }

        [Display(Name = "Catégorie")]
        [Required(ErrorMessage = "La catégorie du service est requise")]
        public int CategorieId { get; set; }

        public List<SelectListItem> Categories { get; set; }

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
