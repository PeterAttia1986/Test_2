using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class user
    {

        public String fname;
        public String lname;
        public String tel;
        public static int sum = 0;

        public user(String fname, String lname, String tel)
        {
            this.fname = fname;
            this.lname = lname;
            this.tel = tel;
            sum++;
        }


    }
}
