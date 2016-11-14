using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testy1.Models
{
    public class Customer : TableEntity
    {
        public Customer()
        {

        }
        public Customer(string partitionKey, string rowKey) : base (partitionKey,rowKey)
        {
            this.PartitionKey = "Customer";
            this.RowKey = Id.ToString();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}