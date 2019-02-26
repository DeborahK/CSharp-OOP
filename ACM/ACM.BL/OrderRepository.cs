using System;

namespace ACM.BL
{
  public class OrderRepository
  {
    /// <summary>
    /// Retrieve one order.
    /// </summary>
    public Order Retrieve(int orderId)
    {
      // Create the instance of the Order class
      // Pass in the requested Id
      Order order = new Order(orderId);

      // Code that retrieves the defined order

      // Temporary hard-coded values to return 
      // a populated order
      if (orderId == 10)
      {
        // Use current year in hard-coded data
        order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                             new TimeSpan(7, 0, 0));
      }

      return order;
    }

    /// <summary>
    /// Saves the current order.
    /// </summary>
    /// <returns></returns>
    public bool Save(Order order)
    {
      var success = true;

      if (order.HasChanges)
      {
        if (order.IsValid)
        {
          if (order.IsNew)
          {
            // Call an Insert Stored Procedure

          }
          else
          {
            // Call an Update Stored Procedure
          }
        }
        else
        {
          success = false;
        }
      }
      return success;
    }

  }
}
