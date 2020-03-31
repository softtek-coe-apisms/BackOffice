using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EcommerseAdmin.Helper
{
    public class ProductAPI
    {
        private string _relativeURI;
        public ProductAPI()
        {
            _relativeURI = Environment.GetEnvironmentVariable("ProductCatalogUrl");
        }
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_relativeURI);
            return client;
        }
    }
}
