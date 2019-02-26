using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
  [TestClass()]
  public class ProductRepositoryTest
  {
    [TestMethod()]
    public void RetrieveTest()
    {
      //-- Arrange
      var productRepository = new ProductRepository();
      var expected = new Product(2)
      {
        CurrentPrice = 15.96M,
        ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
        ProductName = "Sunflowers"
      };

      //-- Act
      var actual = productRepository.Retrieve(2);

      //-- Assert
      Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
      Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
      Assert.AreEqual(expected.ProductName, actual.ProductName);
    }

    [TestMethod()]
    public void SaveTestValid()
    {
      //-- Arrange
      var productRepository = new ProductRepository();
      var updatedProduct = new Product(2)
      {
        CurrentPrice = 18M,
        ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
        ProductName = "Sunflowers",
        HasChanges = true
      };

      //-- Act
      var actual = productRepository.Save(updatedProduct);

      //-- Assert
      Assert.AreEqual(true, actual);
    }

    [TestMethod()]
    public void SaveTestMissingPrice()
    {
      //-- Arrange
      var productRepository = new ProductRepository();
      var updatedProduct = new Product(2)
      {
        CurrentPrice = null,
        ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
        ProductName = "Sunflowers",
        HasChanges = true
      };

      //-- Act
      var actual = productRepository.Save(updatedProduct);

      //-- Assert
      Assert.AreEqual(false, actual);
    }


  }
}
