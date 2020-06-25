using hhoner89.eCommerce.Contracts.WebStore.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore = hhoner89.eCommerce.Contracts.WebStore.Sales;

namespace hhoner89.eCommerce.Managers.Sales
{
    class OrderManager : ManagerBase, WebStore.IWebStoreCartManager, WebStore.IWwebStoreOrderManager
    {
    }
}
