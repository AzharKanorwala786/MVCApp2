namespace MVCApp.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("verification")]
    public partial class verification
    {
        public int Id { get; set; }

        [Required]     
        public string Photo { get; set; }

        [Column("[Document")]
        [Required]  
        public string C_Document { get; set; }
    }
}
