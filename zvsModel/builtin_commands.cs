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
    using System.Collections.ObjectModel;
    using System.Linq;
    
    public partial class builtin_commands
    {
        public builtin_commands()
        {
            this.builtin_command_options = new ObservableCollection<builtin_command_options>();
            this.builtin_command_que = new ObservableCollection<builtin_command_que>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string friendly_name { get; set; }
        public int arg_data_type { get; set; }
        public string custom_data1 { get; set; }
        public string custom_data2 { get; set; }
        public string description { get; set; }
        public bool show_on_dynamic_obj_list { get; set; }
        public string help { get; set; }
        public Nullable<int> sort_order { get; set; }
    
        public virtual ObservableCollection<builtin_command_options> builtin_command_options { get; set; }
        public virtual ObservableCollection<builtin_command_que> builtin_command_que { get; set; }
        }


    }
}
