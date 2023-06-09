﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChatApp.Models
{
    [Table("Filess")]
    public class Filess
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string FileType { get; set; }
        [MaxLength]
        public byte[] DataFiles { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
