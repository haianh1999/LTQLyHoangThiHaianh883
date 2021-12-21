﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1721050883.Models
{
    public class NhaCungCap883
    {
        [Key]
        [Display(Name = "Mã Nhà Cung Cấp")]
        public int MaNhaCungCap { get; set; }


        [Display(Name = "Tên Nhà Cung Cấp")]
        [StringLength(50)]
        public string TenNhaCungCap { get; set; }
    }
}