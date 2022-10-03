using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC5
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[,] i_Num = new int[3,3]
            {
                {7,8,9 },
                {1,4,3 },
                {2,5,6 }
            };

            mt_GetMost(i_Num);


        }
        int mt_GetMost(int[,] i_Num)
        {
            
            return 0;
        }
    }
}