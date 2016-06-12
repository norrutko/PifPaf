using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Strzelnica
{
    public class myWindow : Window
    {
        public bool open;
        public myWindow()
        {
            open = true;
            this.Show();
        }
        bool OpenWindow()
        {
            if(open == true)
            {
                this.Show();
            }
            return open;
        }
        ~myWindow()
        {


        }
        
    }
}
