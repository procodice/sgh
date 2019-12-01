using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sgh1.Products;
using Sgh1.Products.Repositories;

namespace Sgh1.Tests
{
    [TestClass]
    public class AddProduct
    {
        [TestMethod]
        public void TestMethod1()
        {
            //to by przyszlo z bazy gotowe
            var category = new Category("Cukierki");
            var newProduct = new Product(category, "tiki-taki", 10);

            newProduct.Save();

            newProduct.DispatchEvents();

            Assert.IsTrue(ProductRepository.GetProducts().Count > 0);
        }
    }
}
