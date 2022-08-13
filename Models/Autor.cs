using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Autor]")]
    public class Autor
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
    }
}