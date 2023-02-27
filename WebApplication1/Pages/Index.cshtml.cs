using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using System.Collections;
using System;
using WebApplication1.Attributes.Contract;
using WebApplication1.Attributes.ContractService;
using Mit.Store.Catalog.Attributes;
using WebApplication1.Mit.Store.Catalog.Domain.Attributes;

namespace WebApplication1.Pages
{



    public class service1
    {
   

        private readonly IMongoCollection<ProductAttribute> mongoCollection;

        public service1(IMongoCollection<ProductAttribute> mongoCollection)
        {
            this.mongoCollection = mongoCollection;
        }

        public void InsertOne(ProductAttribute attribute)
        {
            mongoCollection.InsertOne(attribute);
        }

  

    }
    public class BigDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string BooksCollectionName { get; set; } = null!;
    }


    public class IndexModel : PageModel
    {
        public IndexModel(IAttributeService service)
        {
            this.service = service;
        }

        private readonly IAttributeService service;

    

        public void OnGet()
        {

            

            ProductAttribute attribute = new ProductAttribute
               ( "testtitle", "testname", ElementType.Text, 1, new List<AttributeValue>
              {
              new AttributeValue
              {

                   Key=87,
                   Value="sdsdsddssvalllllll"
              }
              });
      
    service.AddAttribute(attribute);
        }
    }
}