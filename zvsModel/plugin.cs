//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zVirtualScenesModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    public partial class plugin : INotifyPropertyChanged 
    {
        public plugin()
        {
            this.device_types = new ObservableCollection<device_types>();
            this.plugin_settings = new ObservableCollection<plugin_settings>();
        }

        private int _id;
        public int id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged("id");
            }
        }

        private string _friendly_name;
        public string friendly_name
        {
            get { return _friendly_name; }
            set
            {
                _friendly_name = value;
                NotifyPropertyChanged("friendly_name");
            }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("name");
            }
        }

        private bool _enabled;
        public bool enabled
        {
            get { return _enabled; }
            set
            {
                _enabled = value;
                NotifyPropertyChanged("enabled");
            }
        }

        private string _description;
        public string description
        {
            get { return _description; }
            set
            {
                _description = value;
                NotifyPropertyChanged("description");
            }
        }
       
        public virtual ObservableCollection<device_types> device_types { get; set; }
        public virtual ObservableCollection<plugin_settings> plugin_settings { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}