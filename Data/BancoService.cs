using Raven.Client.Documents;

namespace ProjetoBD.Data
{
    public class BancoService
    {
        private readonly IDocumentStore store;

        public BancoService()
        {
            store = DocumentStoreHolder.Store;
        }

        //adicionar um documento
        public async Task AddDocumento<T>(T document)
        {
            using (var session = store.OpenAsyncSession())
            {
                await session.StoreAsync(document);
                await session.SaveChangesAsync();
            }
        }

        //buscar um documento por id
        public async Task<T> GetDocumentoById<T>(string id)
        {
            using (var session = store.OpenAsyncSession())
            {
                return await session.LoadAsync<T>(id);
            }
        }

        //buscar todos os documentos de um tipo
        public async Task<List<T>> GetAllDocumentos<T>()
        {
            using (var session = store.OpenAsyncSession())
            {
                return await session.Query<T>().ToListAsync();
            }
        }
    }
}
