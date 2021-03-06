﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioDesenv.Models
{
    public class Cliente
    {
        [Key]
        public int clienteID { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public string dataDeNascimento { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public int Telefone { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}