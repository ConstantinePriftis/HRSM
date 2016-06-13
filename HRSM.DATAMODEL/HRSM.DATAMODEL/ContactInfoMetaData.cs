using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRSM.DATAMODEL
{
    public class ContactInfoMetaData
    {
        [Display(Name = "�������� �������")]
        public string PHONE1 { get; set; }
        [Display(Name = "�������� ������")]
        public string PHONE2 { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [Display(Name = "Email")]
        public string EMAIL { get; set; }
    }
}
