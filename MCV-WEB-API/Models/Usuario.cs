﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MCV_WEB_API.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string SobreNome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        
        public string Token { get; set; }

        //Data de cadastro
        [DataType(DataType.DateTime)]
        public DateTime dt_timestamp { get; set; }

        //Data do token
        [DataType(DataType.DateTime)]
        public DateTime dt_token { get; set; }
    }
}