﻿using System.ComponentModel.DataAnnotations;

namespace InfraTeste.Models
{
    public class Clientes
    {
        /// <summary>
        /// Id do cliente
        /// </summary>
        [Required]
        public int id { get; set; }
        /// <summary>
        /// Nome do cliente
        /// </summary>
        [MaxLength(20)]
        public string nome { get; set;  }
        /// <summary>
        /// Cpf do cliente
        /// </summary>
        public string cpf { get; set; }
        /// <summary>
        /// Situação do cliente
        /// </summary>
        public bool isAtivo { get; set; }
    }
}
