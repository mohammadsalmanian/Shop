﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Shapino.DataLayer.Entities.Common
{
    public class BaseEntity
    {
        [Key] 
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
