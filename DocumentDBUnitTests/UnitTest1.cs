using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PocketMusic.Storage.DocumentDBStorage;
using PocketMusic.Storage.DataStorage;
using PocketMusic.Storage.DataStorage.Models;
using Nito.AsyncEx.UnitTests;

namespace DocumentDBUnitTests
{
    [AsyncTestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async void UpsertItemSuccess()
        {
            DocumentDBStorage storage = new DocumentDBStorage(PMDataType.Test);

            FileItem fileItem = new FileItem();
            fileItem.Id = Guid.NewGuid();

            var result = await storage.UpsertFileItem(fileItem);

            Assert.AreEqual(true, result);

        }
    }
}
