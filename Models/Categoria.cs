using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Categoria]")]
    public class Categoria
    {
        public Guid? Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}