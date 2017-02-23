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
        // Collectionname
        private string _collectionName;
        // DocumentDB client
        private DocumentClient _client;

        public DocumentDBStorage(PMDataType type)
        {
            _client = new DocumentClient(new Uri(_connectionString), _primaryKey);

            CreateDatabaseIfNotExists(_dataBaseName);

            _collectionName = type.ToString();

            CreateDocumentCollectionIfNotExists(_dataBaseName, _collectionName);
        }

        public async Task<bool> DeleteFileItem(Guid id)
        {
            try
            {
                await _client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(_dataBaseName, _collectionName, id.ToString()));
            }
            catch
            {
                return false;
            }

            return true;
        }

        public async Task<FileItem> GetFileItem(Guid id)
        {
            try
            {
                var response = await _client.ReadDocumentAsync(UriFactory.CreateDocumentUri(_dataBaseName, _collectionName, id.ToString()));

                FileItem fileItem = (FileItem)(dynamic)response.Resource;

                return fileItem;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<FileItem>> QueryFileItems(string query)
        {
            List<FileItem> result = new List<FileItem>();

            try
            {
                // Leave Max item count to infinity for now
                FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1 };

                // Execute Query
                IQueryable<FileItem> fileQuery = _client.CreateDocumentQuery<FileItem>(
                        UriFactory.CreateDocumentCollectionUri(_dataBaseName, _collectionName),
                        query,
                        queryOptions);

                foreach (var item in fileQuery)
                {
                    result.Add(item);
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpsertFileItem(FileItem fileItem)
        {
            try
            {
                await _client.UpsertDocumentAsync(UriFactory.CreateDocumentUri(_dataBaseName, _collectionName, fileItem.Id.ToString()), fileItem);
            }
            catch
            {
                return false;
            }

            return true;
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
