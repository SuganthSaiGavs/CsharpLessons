using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace NWindBackwardEnginerring.Models
{
    public class RepositoryOrder
    {
        private readonly NorthwindContext _context;

        // Parameterless constructor
        public RepositoryOrder()
        {

        }
        public RepositoryOrder(NorthwindContext context)
        {
           _context = context;
        }
/*        public int SelectedId { get; set; } 

        public List<SelectListItem> OrderSelectView { get; set; }*/

        public List<Order> GetAllOrder()
        {
            return _context.Orders.ToList();
        }

       public List<int> GetAllOrderId()
        {

            return (from o in _context.OrderDetails select o.OrderId).ToList();

        }

        public  List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
/*            Order order=_context.Orders.Find(id);
            return order.OrderDetails.ToList();*/
            
            List<Order> ordersWithOrderDetails= _context.Orders.Include(d=>d.OrderDetails).ToList();    //include child values also
            Order order = ordersWithOrderDetails.FirstOrDefault(x => x.OrderId==id); // orderdetails.order id==id(order id)
            return order.OrderDetails.ToList();

        }

        public Order PutOrder(int id)
        {
            Console.WriteLine($"searching id: {id}");
            Order order = _context.Orders.Find(id);
            return order;
        }


        public Order FindOrderByID(int id)
        {
            var orderById = _context.Orders.Find(id);
            return orderById;

        }

        public List<Order> FindOrderByCustomerID(string CustomerID)
        {
            List<Order> CustomerOrders = (from o in _context.Orders
                                          where o.CustomerId == CustomerID
                                          select o).ToList();
            return CustomerOrders;
        }
/*        public List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
            return _context.OrderDetails.Where(od => od.OrderId == id).ToList();
        }*/

        public Product GetProductById(int productid)
        {
            return _context.Products.Find(productid);

        }
    }
}
