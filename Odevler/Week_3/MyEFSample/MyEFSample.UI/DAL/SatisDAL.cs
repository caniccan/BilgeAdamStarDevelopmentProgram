using MyEFSample.UI.DTO;
using MyEFSample.UI.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyEFSample.UI.DAL
{
    public class SatisDAL
    {
        public bool SatisYap(OrderDTO satis, List<OrderDetailsDTO> satisDetay)
        {
            bool sonuc = false;
            using (TransactionScope tran = new TransactionScope())
            {
                try
                {
                    using (NorthwindEntities db = new NorthwindEntities())
                    {
                        Order siparis = db.Orders.Add(Extension.OrderDTOtoOrder(satis));
                        if (db.SaveChanges()>0)
                        {
                            foreach (OrderDetailsDTO item in satisDetay)
                            {
                                item.OrderID = siparis.OrderID;
                                db.Order_Details.Add(Extension.OrderDetailsDTOtoOrderDetails(item));
                                //db.Products.Attach(Extension.OrderDetailsDTOtoOrderDetails(item));
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            throw new Exception("hata");
                        }

                    }
                    tran.Complete();
                    sonuc = true;
                }
                catch (Exception ex)
                {
                    tran.Dispose();
                }
            }
            return sonuc;
        }
    }
}
