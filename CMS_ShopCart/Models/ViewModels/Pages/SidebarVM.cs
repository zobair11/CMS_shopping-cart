using CMS_ShopCart.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS_ShopCart.Models.ViewModels.Pages
{
    public class SidebarVM
    {
        public SidebarVM()
        {

        }

        public SidebarVM(SidebarDTO row)
        {
            id = row.id;
            Body = row.Body;
        }



        public int id { get; set; }
        [AllowHtml]
        public string Body { get; set; }
    }
}