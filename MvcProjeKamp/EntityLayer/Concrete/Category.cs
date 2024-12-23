using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(1000)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //Öncelikle benim bir kategorimin birden fazla başlığı olacaktır.Yani bire çok ilişkim var.
        //ICollection oluşturmak demek,ben bu sınıfa bağlı bir koleksiyon oluşturacağım demektir.
        //Ve bu koleksiyon Heading'ten olacaktır.Çünkü Headingle ilişki kuracağı içindir.
        //Burda oluşturulan property'nin ismi de Headings olsun dedik.Ardından işlemler Headingte...
        
        public ICollection<Heading> Headings { get; set; }
    }
}
