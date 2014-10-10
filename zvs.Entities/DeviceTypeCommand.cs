﻿using System.ComponentModel.DataAnnotations.Schema;

namespace zvs.Entities
{
    [Table("DeviceTypeCommands", Schema = "ZVS")]
    public class DeviceTypeCommand : Command
    {
        public int DeviceTypeId { get; set; }
        public virtual DeviceType DeviceType { get; set; }
    }
}
