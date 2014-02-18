using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VIPService.Models {
    [Table("Record")]
    public class Record {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int RecordId { get; set; }
        public int VIPId { get; set; }
        [ForeignKey("VIPId")]
        public VIP VIP { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime IssueTime { get; set; }
        public int Cost { get; set; }
        public int Points { get; set; }
        public string ItemId { get; set; }
        public int ItemPrice { get; set; }
        public int ItemDealPrice { get; set; }
        public int ItemQty { get; set; }
        public string ItemColor { get; set; }
        public string ItemSize { get; set; }
        public string RecordDescription { get; set; }
        public string RecordTag { get; set; }
    }
}