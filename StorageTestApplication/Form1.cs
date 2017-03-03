using AzureBlobStorage;
using Newtonsoft.Json;
using PocketMusic.Storage.DataStorage;
using PocketMusic.Storage.DataStorage.Models;
using PocketMusic.Storage.DocumentDBStorage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageTestApplication
{
    public partial class DocumentDBTestForm : Form
    {
        DocumentDBStorage _storage;

        BlobStorage _blobStorage;

        public DocumentDBTestForm()
        {
            InitializeComponent();
        }

        private async void createDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                _storage = new DocumentDBStorage(PMDataType.Test);
                await _storage.CreateDatabaseAndDocument();
                resultTextBox.Text = "Created Database";
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
            }
            
        }

        private async void upsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = new FileItem(Guid.NewGuid(),PMDataType.Test);

                fileItem.Data.Add("test", "value");
                fileItem.Data.Add("test1", "value1");
                fileItem.Data.Add("test2", "value2");
                fileItem.Data.Add("test3", "value3");

                fileItem.BlobLinks.Add("test", "value");
                fileItem.BlobLinks.Add("test1", "value1");
                fileItem.BlobLinks.Add("test2", "value2");
                fileItem.BlobLinks.Add("test3", "value3");

                fileItem.MetaData.Add("test", "value");
                fileItem.MetaData.Add("test1", "value1");
                fileItem.MetaData.Add("test2", "value2");
                fileItem.MetaData.Add("test3", "value3");

                var result = await _storage.UpsertFileItem(fileItem);

                resultTextBox.Text = String.Format("Upserted item with id {0}", fileItem.id.ToString());
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
            }
        }

        private async void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = new Guid(idTextBox.Text);

                var result = await _storage.GetFileItem(id);

                resultTextBox.Text = JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = new Guid(idTextBox.Text);

                var result = await _storage.DeleteFileItem(id);

                resultTextBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
            }
        }

        private void createBlobClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                _blobStorage = new BlobStorage("test");

                resultTextBox.Text = "Client created and test container created.";
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
            }
        }

        private async void uploadTestFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                var Uri = await _blobStorage.UploadBlob(Guid.Parse(fileIdTextBox.Text), blobNameTextBox.Text, localPathTextBox.Text);

                resultTextBox.Text = "Blob uploaded to " + Uri.ToString();
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
            }
        }

        private void RandomGuidButton_Click(object sender, EventArgs e)
        {
            fileIdTextBox.Text = Guid.NewGuid().ToString();
        }

        private async void deleteTestFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _blobStorage.DeleteBlob(Guid.Parse(fileIdTextBox.Text), blobNameTextBox.Text);

                resultTextBox.Text = "Blob " + fileIdTextBox.Text + " Deleted";
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
            }
        }
    }
}
