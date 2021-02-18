﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class ItemPkgDTO
    {
        public ItemDTO Item { get; set; }
        public PhotoDTO Photo { get; set; }
        public AddressDTO Address { get; set; }
    }


    public class ItemDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float? Deposit { get; set; }
        public float? Fee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int AddressId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Status { get; set; }
        public string StatusName { get; set; }
    }

    public class PhotoDTO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string FileName { get; set; }
    }

}
