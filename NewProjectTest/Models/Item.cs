using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NewProjectTest.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Office { get; set; }
        public string State { get; set; }
        public string CutDate { get; set; }
        public string Switch1 { get; set; }
        public string Switch2 { get; set; }
        [DisplayName("HostClli")]
        public string HostClli { get; set; }
        [DisplayName("OldClli")]
        public string OldClli { get; set; }
        [DisplayName("NewClli")]
        public string NewClli { get; set; }
        [DisplayName("ProjectManager")]
        public string ProjectManager { get; set; }
        [DisplayName("LCSManager")]
        public string LCSManager { get; set; }
        [DisplayName("DTRManager")]
        public string DTRManager { get; set; }

    }

        }

