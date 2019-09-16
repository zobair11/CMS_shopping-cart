﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CMS_ShopCart.Models.Data
{
    [Table("tblSidebar")]
    public class SidebarDTO
    {
        [Key]
        public int id { get; set; }
        public string Body { get; set; }
    }
}