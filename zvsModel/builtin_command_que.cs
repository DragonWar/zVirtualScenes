//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zvsModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class builtin_command_que
    {
        public int id { get; set; }
        public string arg { get; set; }
        public int builtin_command_id { get; set; }
    
        public virtual builtin_commands builtin_commands { get; set; }
    }
}
