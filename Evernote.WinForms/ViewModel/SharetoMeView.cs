using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.WinForms.ViewModel
{
    public class SharetoMeView
    {
        public Guid Id { get; set; }
        [DisplayName("От кого")]
        public string Owner { get; set; }
        [DisplayName("Название")]
        public string header { get; set; }
        [DisplayName("Создана")]
        public DateTime Created { get; set; }
        [DisplayName("Изменена")]
        public DateTime Changed { get; set; }
    }
}
