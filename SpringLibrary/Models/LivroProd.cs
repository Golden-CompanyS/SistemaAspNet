using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpringLibrary.Models
{
    public class LivroProd
    {
        [Display(Name = "ISBN do livro")]
        public string isbn { get; set; }

        [Display(Name = "Código do produto")]
        public int prodCod { get; set; }
    }
}