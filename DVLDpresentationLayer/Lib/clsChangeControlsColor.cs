using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Lib
{
    public static class clsChangeControlsColor
    {
        private static void ChangeGunaButtonColor(Guna2Button btn)
        {
            btn.FillColor = clsColors.DarkColor;
        }
        public static void ChangeGunaButtonsColor(Form frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is Guna2Button)
                    ChangeGunaButtonColor((Guna2Button)control);
            }
        }
        public static void ChangeGunaButtonsColor(Guna2Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2Button)
                    ChangeGunaButtonColor((Guna2Button)control);
            }
        }
        public static void ChangeGunaButtonsColor(Guna2CustomGradientPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2Button)
                    ChangeGunaButtonColor((Guna2Button)control);
            }
        }
        public static void ChangeGunaButtonsColor(Guna2GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is Guna2Button)
                    ChangeGunaButtonColor((Guna2Button)control);
            }
        }
    }
}
