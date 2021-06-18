using System.Threading;
using System.Threading.Tasks;
using AspNetApi.Controllers;
using AspNetMvc.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace AspTest
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Contexto> _mockContexto;
        private readonly Categoria _categoria;
        
        public CategoriasControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContexto = new Mock<Contexto>();
            _categoria = new Categoria {Id = 1, Descricao = "Teste Categoria"};

            _mockContexto.Setup(m => m.Categorias).Returns(_mockSet.Object);
            
            _mockContexto.Setup(m => m.Categorias.FindAsync(1))
                .ReturnsAsync(_categoria);

            _mockContexto.Setup(m => m.SetModified(_categoria));

            _mockContexto.Setup(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(1);
        }

        [Fact]
        public async Task Put_Categoria()
        {
            var service = new CategoriasController(_mockContexto.Object);

            await service.PutCategoria(1, _categoria);
            
            _mockContexto.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once());

        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContexto.Object);

            await service.GetCategoria(1);
            
            _mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }

        [Fact]
        public async Task Post_Categoria()
        {
            var service = new CategoriasController(_mockContexto.Object);
            await service.PostCategoria(_categoria);
            
            _mockSet.Verify(x => x.Add(_categoria), Times.Once);
            _mockContexto.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once());
        }

        [Fact]
        public async Task Delete_Categoria()
        {
            var service = new CategoriasController(_mockContexto.Object);
            await service.DeleteCategoria(1);
            
            _mockSet.Verify(m => m.FindAsync(1), Times.Once());
            
            _mockContexto.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once());
        }
    }
}