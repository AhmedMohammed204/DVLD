using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlButton : UserControl
    {
        public event Action<Button> OnButtonClick;
        protected virtual void ButtonClicked(Button btn)
        {
            Action<Button> handler = OnButtonClick;
            if (handler != null)
            {
                handler(btn);
            }
        }

        public string btnTxt
        {
            get
            {
                return btn.Text;
            }
            set
            {
                btn.Text = value;
            }
        }
        public ctrlButton()
        {
            InitializeComponent();
            btn.BackColor = clsColors.MidColor;
            btn.ForeColor = clsColors.DarkColor;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            btn.BackColor = clsColors.DarkColor;
            btn.ForeColor = clsColors.MidColor;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            btn.BackColor = clsColors.MidColor;
            btn.ForeColor = clsColors.DarkColor;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(OnButtonClick != null)
                OnButtonClick(btn);
        }
    }
}
