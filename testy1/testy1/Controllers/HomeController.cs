using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using testy1.Models;

namespace testy1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private CloudStorageAccount storageAccount;
        private CloudTableClient tableClient;
        private CloudTable table;

        public HomeController()
        {
            storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=t41617;AccountKey=7p7rsLTT+wLdMnS/1yHZDCVETOIoXpAQjyrkKutLbK7KVNq8f1HtRMl4vyQpiZv8jQyq5aa4o17PfXiC2OUU0Q==");
            tableClient = storageAccount.CreateCloudTableClient();
            table = tableClient.GetTableReference("dbmontdev");
            //table.CreateIfNotExists();

            Customer c = new Customer()
            {
                Id = new Guid(),
                FirstName = "Urban",
                LastName = "Suedi"
            };
            TableOperation insertOperation = TableOperation.Insert(c);
            table.Execute(insertOperation);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}