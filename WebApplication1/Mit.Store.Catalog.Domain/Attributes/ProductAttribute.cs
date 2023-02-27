using Mit.Store.Catalog.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebApplication1.Mit.Store.Catalog.Domain.Attributes
{


    public class ProductAttribute
    {
        public ProductAttribute(string title, string name, ElementType elementType, int unitId, List<AttributeValue> values)
        {

            Title = title;
            Name = name;
            ElementType = elementType;
            UnitId = unitId;
            Values = values;
            Id = ObjectId.GenerateNewId().ToString();
        }

        public string Id { get; protected set; }
        public string Title { get; protected set; }
        public string Name { get; protected set; }
        public ElementType ElementType { get; protected set; }
        public int UnitId { get; protected set; }
        // public DataType dataTypeDataType { get; protected set; }


        public List<AttributeValue> Values { get; protected set; }

    }
}
