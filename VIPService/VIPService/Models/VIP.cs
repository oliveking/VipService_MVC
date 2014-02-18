using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace VIPService.Models {
    [Table("VIP")]
    public class VIP {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int VIPId { get; set; }
        public string VIPName { get; set; }
        [DataType(DataType.Date)]
        public DateTime? VIPDOB { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string VIPTel { get; set; }
        public string VIPTag { get; set; }
        public int RegisterShopId { get; set; }
        [ForeignKey("RegisterShopId")]
        public Shop Shop { get; set; }
    }
}