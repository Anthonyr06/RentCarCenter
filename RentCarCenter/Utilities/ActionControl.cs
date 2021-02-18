using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentCarCenter.Utilities
{
    public class ActionControl
    {
        
        public static void ClearTextBoxes(params TextBox[] controls)
        {
            foreach (var control in controls)
            {
                control.Clear();
            }
        }
    }
}
