using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiDonemOdevi.DAL
{
    //veri tabanı kullanımını soyutlayarak işlemleri yapan class.  
    class CustomerManager
    {
        private ICustomerDAL DAL;
        public CustomerManager (ICustomerDAL DAL)
        {
            this.DAL = DAL;
        }
        //ekleme işlemini yapar
        public void Add(string value, string sutunad, string tabload)
        {
            DAL.Add(value, sutunad, tabload);
        }
        //güncelleme işlemini yapar
        public void Update(string tabload, string sutunad, string value, string sartdeger, string sartsutunad)
        {
            DAL.Update(tabload, sutunad, value, sartdeger, sartsutunad);
        }
        //silme işlemini yapar
        public void Delete(int value, string sutunad, string tabload)
        {
            DAL.Delete(value, sutunad, tabload);
        }
        //girilen şarta göre tek veri bir veri seçer 
        public string tekselect(string value, string sart, string sutunad, string tabload)
        {
            return DAL.tekselect(value, sart, sutunad, tabload);
        }
        //girilen şarta göre bir çok veriyi aynanda seçer
        public List<string> select(string value, string sart, string sutunad, string tabload)
        {
            return DAL.select(value,sart,sutunad,tabload);
        }
    }
}
