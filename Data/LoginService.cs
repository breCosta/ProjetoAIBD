using ProjetoBD.Entidades;
using Raven.Client.Documents;

namespace ProjetoBD.Data
{
    public class LoginService
    {
        private readonly IDocumentStore store;

        public LoginService()
        {
            store = DocumentStoreHolder.Store;
        }

        public async Task<Candidato> GetCandidatoByEmail(string email)
        {
            using (var session = store.OpenAsyncSession())
            {
                var query = session.Advanced.AsyncRawQuery<Candidato>("from Candidato where Contato.Email = $email").AddParameter("email", email);

                return await query.FirstOrDefaultAsync();
            }
        }
    }
}
