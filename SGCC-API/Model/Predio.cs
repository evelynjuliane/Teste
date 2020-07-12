﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SGCC_API.Model
{
    public class Predio
    {
        [Key]
        public int IdPredio { get; set; }
        public int Bloco { get; set; }
        public int NumeroPredio { get; set; }
        public int NumAndares { get; set; }
    }
}