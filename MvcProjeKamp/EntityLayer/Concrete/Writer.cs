using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurName { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }

        [StringLength(30)]
        public string WriterPassword { get; set; }

        //Yazar ile başlık arasında ilişki kurduk ki yazarın hangi başlıkla yazı yazdığını bilelim.
        public ICollection<Heading> Headings { get; set; }

        //Yazar ile içerik arasında da ilişki bulunmak durumundadır çünkü yazar belli bir başlığa 
        //açıklamasını yaptı fakat bu açıklamayı bir yazar belirtmesi gerekir.Yani yazar~content var.

        public ICollection<Content> Contents { get; set; }
    }
}
