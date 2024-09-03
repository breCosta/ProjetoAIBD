using Raven.Client.Documents;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoBD.Data
{
    public class DocumentStoreHolder
    {
        private static readonly Lazy<IDocumentStore> _store = new Lazy<IDocumentStore>(CreateDocumentStore);

        private static IDocumentStore CreateDocumentStore()
        {
            string serverURL = "https://a.bd2.ravendb.community:8080";
            string databaseName = "AIDB";

            IDocumentStore documentStore = new DocumentStore
            {
                Urls = new[] { serverURL },
                Database = databaseName,
                Certificate = new X509Certificate2("C:\\Users\\Brenda\\Downloads\\RavenDB\\Server\\cluster.server.certificate.bd2.pfx")
            };

            documentStore.Initialize();
            return documentStore;
        }

        public static IDocumentStore Store
        {
            get { return _store.Value; }
        }
    }
}
