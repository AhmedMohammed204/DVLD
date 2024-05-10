using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public class clsCloseWindowWithMessage
    {
        public enum enMessageBoxType { Error = 1, Information = 2, Warn = 3 };
        public enum enMessageBoxButtons { Ok = 1, YesNo = 2, OkCansel = 3 };
        private static MessageBoxIcon GetIcon(enMessageBoxType MessageBoxType)
        {
             switch(MessageBoxType)
            {
                case enMessageBoxType.Error:
                    return MessageBoxIcon.Error;
                case enMessageBoxType.Information:
                    return MessageBoxIcon.Information;
                default: return MessageBoxIcon.Warning;
            }
        }
        private static MessageBoxButtons GetButtons(enMessageBoxButtons Buttons)
        {
            switch(Buttons)
            {
                case enMessageBoxButtons.Ok:
                    return MessageBoxButtons.OK;
                case enMessageBoxButtons.OkCansel:
                    return MessageBoxButtons.OKCancel;
                default: return MessageBoxButtons.YesNo;
            }
        }
        public static void CloseWindow(Form FormToClose,string txt, string Caption,enMessageBoxButtons Buttons , enMessageBoxType MessageBoxType)
        {
            MessageBox.Show(txt, Caption, GetButtons(Buttons), GetIcon(MessageBoxType));
            FormToClose.Close();
            return;
        }

    }
}
