using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace VIPService.Models {
    public class Brand {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int BrandId { get; set; }
        [Display(Name = "品牌名")]
        public string BrandName { get; set; }
        [Display(Name = "品牌描述")]
        public string BrandDescription { get; set; }
    }
}