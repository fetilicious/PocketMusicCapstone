using PocketMusic.Storage.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketMusic.Storage.DataStorage.Models;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents;

namespace PocketMusic.Storage.DocumentDBStorage
{
    public class DocumentDBStorage : IStorage
    {
        /// Hard coded connection string
        private const string _connectionString = "https://pocketmusic.documents.azure.com:443/";

        // Hard coded primary key
        private const string _primaryKey = "YDlE8zGjyDBLh0EuFqXnKaoRSHdzkxuM8HfIE4RRj4R1054XPgsKwsPOVOPC8TqN4eA29XaKwwwqXn47MRFOEw==";

        // Hard coded database name
        private const string _dataBaseName = "PocketMusicMain";

        // DocumentDB client
        private DocumentClient _client;

        public DocumentDBStorage(PMDataType type)
        {
            _client = new DocumentClient(new Uri(_connectionString), _primaryKey);

            CreateDatabaseIfNotExists(_dataBaseName);

            CreateDocumentCollectionIfNotExists(_dataBaseName, type.ToString());
        }

        public Task<bool> DeleteFileItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetFileItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpsertFileItem(FileItem fileItem)
        {
            throw new NotImplementedException();
        }

        private void CreateDatabaseIfNotExists(string databaseName)
        {
            // Check to verify a database with the id=FamilyDB does not exist
            try
            {
                _client.ReadDatabaseAsync(UriFactory.CreateDatabaseUri(databaseName));
            }
            catch
            {
                _client.CreateDatabaseAsync(new Database { Id = databaseName });
            }
        }

        private void CreateDocumentCollectionIfNotExists(string databaseName, string collectionName)
        {
            try
            {
                _client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName));
            }
            catch (DocumentClientException de)
            {
                DocumentCollection collectionInfo = new DocumentCollection();
                collectionInfo.Id = collectionName;

                // Configure collections for maximum query flexibility including string range queries.
                collectionInfo.IndexingPolicy = new IndexingPolicy(new RangeIndex(DataType.String) { Precision = -1 });

                // Here we create a collection with 200 RU/s.
                _client.CreateDocumentCollectionAsync(
                    UriFactory.CreateDatabaseUri(databaseName),
                    collectionInfo,
                    new RequestOptions { OfferThroughput = 200 });
            }
        }
    }
}
