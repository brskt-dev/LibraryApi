using LibraryApi.Models;

namespace LibraryApi.Services.Autor;

public class AutorService : IAutorInterface
{
    public Task<ResponseModel<List<AutorModel>>> ListarAutores()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<AutorModel>> BuscarAutor(int idAutor)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro)
    {
        throw new NotImplementedException();
    }
}