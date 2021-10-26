using HTPTCSClient.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using RestSharp.Extensions;
using System.IO;
using FileInfo = HTPTCSClient.Model.FileInfo;

namespace HTPTCSClient.Controller
{
     public class WSController
    {

        private readonly JsonSerializerSettings SerializerSettings;
        private RestClient RestClient;
        private readonly string BasePath1 = "http://";
        private readonly string BasePath2 = ":8080/HTPTWS/webapi/files/";
        public WSController()
        {
            SerializerSettings = new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-ddTH:mm:ss.fff"
            };
        }

        public void RefreshRestClient(string IP)
        {
            string API_URL = BasePath1 + IP + BasePath2;
            this.RestClient = new RestClient(API_URL);
        }

        public List<FileInfo> GetAllFileInfos()
        {
            var request = new RestRequest("list", Method.GET);
            RestClient.Timeout = 4000;
            var respone = RestClient.Execute(request);
            if (!respone.IsSuccessful)
            {
                return null;
            }
            var content = respone.Content;
            Console.WriteLine(content);
            List<FileInfo> infoList = JsonConvert.DeserializeObject<List<FileInfo>>(content, SerializerSettings);
            return infoList;
        }

        

        public MyMessage UploadFile(string filePath) 
        {
            var request = new RestRequest("upload", Method.POST);
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("uploadFile", filePath);
            var response = RestClient.Execute(request);
            MyMessage message = new MyMessage(); 
            if (response.StatusCode == HttpStatusCode.OK)
            {
                message.MStatus = MyMessage.Status.SUCCESS;
            } 
            else
            {
                message.MStatus = MyMessage.Status.FAIL;
            }
            message.Content = response.Content;
            return message;
        }

        public MyMessage DownloadFile(int id, string fullFileName)
        {
            MyMessage message = new MyMessage();
            var request = new RestRequest("download/{id}", Method.GET)
                .AddUrlSegment("id", id);
            var response = RestClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                byte[] downloadBytes = response.RawBytes;
                File.WriteAllBytes(fullFileName, downloadBytes);
                message.MStatus = MyMessage.Status.SUCCESS;
                message.Content = "Tải file thành công!";
            }
            else
            {
                message.MStatus = MyMessage.Status.FAIL;
                message.Content = response.Content;
            }
            return message;
        }

        public MyMessage DeleteFile(int id)
        {
            MyMessage message = new MyMessage();
            var request = new RestRequest("delete/{id}", Method.DELETE)
                .AddUrlSegment("id", id);
            var response = RestClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                message.MStatus = MyMessage.Status.SUCCESS;
            }
            else
            {
                message.MStatus = MyMessage.Status.FAIL;
            }
            message.Content = response.Content;
            return message;
        }
    }
}
