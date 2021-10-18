﻿namespace Tests.Chapter08.Exercises.Exercise04
{
    public class FilesClientTests
    {
        //private readonly BlobServiceClient _blobServiceClient;
        //private readonly BlobContainerClient _defaultContainerClient;

        //public FilesClientTests(string defaultContainer)
        //{
        //    var endpoint = "https://packtstorage2.blob.core.windows.net/";
        //    var account = "packtstorage2";
        //    var key = Environment.GetEnvironmentVariable("BlobStorageKey", EnvironmentVariableTarget.User);
        //    var storageEndpoint = new Uri(endpoint);
        //    var storageCredentials = new StorageSharedKeyCredential(account, key);
        //    _blobServiceClient = new BlobServiceClient(storageEndpoint, storageCredentials);
        //    _defaultContainerClient = CreateContainerIfNotExists(defaultContainer).Result;
        //}

        //public async Task UploadFile(string file, string container)
        //{
        //    var containerClient = await CreateContainerIfNotExists(container);
        //    await UploadFileInternal(file, containerClient);
        //}

        //private async Task<BlobContainerClient> CreateContainerIfNotExists(string container)
        //{
        //    var lowerCaseContainer = container.ToLower();
        //    var containerClient = _blobServiceClient.GetBlobContainerClient(lowerCaseContainer);
        //    if (! await containerClient.ExistsAsync())
        //    {
        //        containerClient = await _blobServiceClient.CreateBlobContainerAsync(lowerCaseContainer);
        //    }

        //    return containerClient;
        //}

        //public Task UploadFile(string file)
        //{
        //    return UploadFileInternal(file, _defaultContainerClient);
        //}

        //private Task UploadFileInternal(string file, BlobContainerClient client)
        //{
        //    var data = new BinaryData(File.ReadAllBytes(file));
        //    return client.UploadBlobAsync(Path.GetFileName(file), data);
        //}

        //public async Task DownloadFile(string filename, string container, string downloadDirectory)
        //{
        //    var containerClient = await CreateContainerIfNotExists(container);
        //    await DownloadFileInternal(filename, downloadDirectory, containerClient);
        //}

        //public Task DownloadFile(string filename, string downloadDirectory)
        //{
        //    return DownloadFileInternal(filename, downloadDirectory, _defaultContainerClient);
        //}

        //private Task DownloadFileInternal(string filename, string downloadDirectory, BlobContainerClient client)
        //{
        //    var blobClient = client.GetBlobClient(filename);
        //    var downloadedFile = Path.Combine(downloadDirectory, filename);
            
        //    if (!Directory.Exists(downloadDirectory))
        //    {
        //        Directory.CreateDirectory(downloadDirectory);
        //    }
            
        //    if (!File.Exists(downloadedFile))
        //    {
        //        var stream = File.Create(downloadedFile);
        //        stream.Dispose();
        //    }
        //    return blobClient.DownloadToAsync(downloadedFile);
        //}
    }
}
