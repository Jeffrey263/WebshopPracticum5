using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebshopDomain;

namespace Webshop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IwebshopService
    {
        //----------------| ALLE PRODUCT SERVICES |----------------------------------------------------
        [OperationContract]
        List<Product> GetAllProducts(string username, string password);

        [OperationContract]
        Product GetProductById(Int32 id, string username, string password);

        [OperationContract]
        void SaveProduct(string name, string desc, Int32 stock, double price);

        //----------------| ALLE USER SERVICES |----------------------------------------------------
        [OperationContract]
        List<User> GetAllUsers(string username, string password);

        [OperationContract]
        User GetUserByID(Int32 id, string username, string password);

        [OperationContract]
        User GetUserByName(string username, string password);

        [OperationContract]
        String SaveNewUser(string name);

        [OperationContract]
        bool CheckUserAuthentication(string username, string password);

        //----------------| ALLE ORDER SERVICES |----------------------------------------------------
        [OperationContract]
        List<int> GetAllOrdersByCustomerID(Int32 cId, string username, string password);

        [OperationContract]
        Order GetOrderByID(Int32 id, string username, string password);

        [OperationContract]
        void SaveNewOrder(User u, List<Order_Product> producten, string username, string password);

        [OperationContract]
        List<OrderProductDTO> GetProductsFromOrder(int orderID, string username, string password);

    }
}
