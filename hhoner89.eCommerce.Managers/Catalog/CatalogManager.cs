using System;
using System.Collections.Generic;
using System.Text;
using Admin = hhoner89.eCommerce.Contracts.Admin.Catalog;
using WebStore = hhoner89.eCommerce.Contracts.WebStore.Catalog;


namespace hhoner89.eCommerce.Managers.Catalog
{
    class CatalogManager : ManagerBase, WebStore.IWebStoreCatalogManager, Admin.IAdminCatalogManager
    {
    }
}
