﻿using System.ComponentModel.DataAnnotations;

namespace CoderCarrer.Models
{
    public class Vaga
    {
        [Key]
        public int id_vaga { get; set; }
        public string data_vaga { get; set; }
        public string titulo { get; set; }
        public string salario { get; set; }
        public string descricao_vaga { get; set; }
        public string empresa { get; set; }
        public string url { get; set; }
    }
}