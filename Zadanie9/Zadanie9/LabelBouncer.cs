using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie9
{
    class LabelBouncer
    {
        public Label MyLabel;
        public bool GoingForword;

        public LabelBouncer(Label MyLabel = null)
        {
            GoingForword = true;
            this.MyLabel = MyLabel;
        }

        public void Move()
        {
            if(MyLabel != null)
            {
                if(GoingForword)
                {
                    MyLabel.Left += 5;

                    if(MyLabel.Left >= MyLabel.Parent.Width - MyLabel.Width)
                    {
                        GoingForword = false;
                    }
                }
                else
                {
                    MyLabel.Left -= 5;

                    if(MyLabel.Left <= 0)
                    {
                        GoingForword = true;
                    }
                }
            }
        }
    }
}
