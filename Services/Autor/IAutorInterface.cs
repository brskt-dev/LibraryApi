using LibraryApi.Models;

namespace LibraryApi.Services.Autor;

public interface IAutorInterface
{
    Task<ResponseModel<List<AutorModel>>> ListarAutores();

    Task<ResponseModel<AutorModel>> BuscarAutor(int idAutor);
    
    Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);
}