using System;
using System.Collections.Generic;
using System.Text;
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace CursoTest
{
    public class CategoriaControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockset;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;

        public CategoriaControllerTest()
        {
            _mockset = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>;
            _categoria = new Categoria { id = 1, Descricao = "Teste Categoria" };
        }
    }
}
