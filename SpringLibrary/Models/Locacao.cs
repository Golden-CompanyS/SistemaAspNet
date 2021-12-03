﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpringLibrary.Models
{
    public class Locacao
    {
        [Display(Name = "Código da Locação")]
        public int locDesc { get; set; }

        [Display(Name = "Descrição da Locação")]
        public string locDesc { get; set; }

        //fazer amanha essas duas:  locHoraIni time not null e locHoraFim time not null,

        [Display(Name = "Data da Locação")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LocData
        {
            get
            {
                return this.locData.HasValue
                ? this.locData.Value
               : DateTime.Now;
            }
            set
            {
                this.locData = value;
            }
        }
        private DateTime? locData = null;

        [Display(Name = "Preço da Locação")]
        public decimal locPreco { get; set; }

        [Display(Name = "Código do Cliente")]
        public int cliCod { get; set; }
    }
}
