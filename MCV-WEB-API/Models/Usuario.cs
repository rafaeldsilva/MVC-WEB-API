﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        public string Token { get; set; }

        //Data de cadastro
        [DataType(DataType.DateTime)]
        public string dt_timestamp { get; set; }

        //Data do token
        [DataType(DataType.DateTime)]
        public string dt_token { get; set; }
    }
}