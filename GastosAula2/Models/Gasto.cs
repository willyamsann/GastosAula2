﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GastosAula2.Models
{
    public class Gasto
    {
        [Key]
        public new int Id { get; set; }
        
        public string Title { get; set; }

        public double Valor { get; set; }

        public DateTime DateAdd { get; set; }

    }
}
