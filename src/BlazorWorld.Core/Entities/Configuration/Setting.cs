﻿using BlazorWorld.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorWorld.Core.Entities.Configuration
{
    public class Setting : Entity
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Object { get; set; }
        [Required]
        public string Key { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
