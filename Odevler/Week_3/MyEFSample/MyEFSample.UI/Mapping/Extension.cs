using MyEFSample.UI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSample.UI.Mapping
{
    public class Extension
    {
        public static OrderDTO OrderToOrderDTO(Order order) 
        {
            return new OrderDTO()
            {
                OrderDate = order.OrderDate,
                OrderID = order.OrderID,
                ShipAddress = order.ShipAddress,
                ShipCity = order.ShipCity,
                ShipName = order.ShipName
            };
        }
        public static Order OrderDTOtoOrder(OrderDTO dto)
        {
            return new Order()
            {
                ShipName = dto.ShipName,
                ShipAddress = dto.ShipAddress,
                OrderID = dto.OrderID,
                OrderDate = dto.OrderDate,
                ShipCity = dto.ShipCity,

            };
        }
        public static Order_Detail OrderDetailsDTOtoOrderDetails(OrderDetailsDTO dto)
        {
            return new Order_Detail()
            {
                OrderID = dto.OrderID,
                Discount = dto.Discount,
                ProductID = dto.ProductID,
                UnitPrice = dto.UnitPrice,
                Quantity = dto.Quantity
            };
        }
        public static OrderDetailsDTO OrderDetailtoOrderDetailsDTO(Order_Detail order_Detail) 
        {
            return new OrderDetailsDTO()
            {
                
                Discount = order_Detail.Discount,
                UnitPrice = order_Detail.UnitPrice,
                ProductID = order_Detail.ProductID,
                OrderID = order_Detail.OrderID
            };
        }

    }
}
