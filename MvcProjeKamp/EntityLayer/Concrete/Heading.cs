using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(100)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        //Burada tanımladığım CategoryID prop'u ile Category'deki CategoryID prop'u kesinlikle aynı olmalıdır.
        //Ardından virtual ile Category'den değer alıyorum ve ilişkimi tamamlıyorum.
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


        //Heading(Başlık) ile de Content(İçerik) arasında ilişki olacağı için adımlar birebir uygulandı.
        public ICollection<Content> Content { get; set; }


        //[Yazar ~ Başlık İlişkisi] 
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
