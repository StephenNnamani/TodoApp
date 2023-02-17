using System;

namespace EFCoreAppDAL.Models
{

    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public byte[] DateTime { get; set; }
    }

}
