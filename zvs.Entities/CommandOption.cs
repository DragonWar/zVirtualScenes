﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zvs.Entities
{
    [Table("CommandOptions", Schema = "ZVS")]
    public partial class CommandOption : BaseOption
    {
        public int CommandOptionId { get; set; }
       
        public virtual Command Command { get; set; }
    }
}