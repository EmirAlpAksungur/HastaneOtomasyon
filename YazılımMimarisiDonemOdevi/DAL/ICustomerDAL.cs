using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiDonemOdevi.DAL
{
    //kullanılacak veri tabanlarının soyutlanması için kullanlan interface
    interface ICustomerDAL
    {
        void Add(string value, string sutunad, string tabload);
        void Update(string tabload, string sutunad, string value, string sartdeger, string sartsutunad);
        void Delete(int value, string sutunad, string tabload);
        string tekselect(string value, string sart, string sutunad, string tabload);
        List<string> select(string value, string sart, string sutunad, string tabload);
    }
}
