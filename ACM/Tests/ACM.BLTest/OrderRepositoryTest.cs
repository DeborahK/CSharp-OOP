using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
  [TestClass()]
  public class OrderRepositoryTests
  {
    [TestMethod()]
    public void RetrieveOrderDisplayTest()
    {
      //-- Arrange
      var orderRepository = new OrderRepository();
      var expected = new Order(10)
      {
        OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                       new TimeSpan(7, 0, 0)),
      };

      //-- Act
      var actual = orderRepository.Retrieve(10);

      //-- Assert
      Assert.AreEqual(expected.OrderDate, actual.OrderDate);
    }
  }
}

