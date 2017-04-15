using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMacro
{
    public partial class AddandEdit : Form
    {
        public string Time { get; set; }
        public string Instruction { get; set; }
        public string KeyorCoordinate { get; set; }
       

        private void AddandEdit_Load()
        {
        }

        public AddandEdit()
        {
            InitializeComponent();
            this.txtTime.Text = "0";
            this.cbboxInstruction.Text = "키보드 누름";
            this.txtKeyorCoordinate.Text = "65";

            this.AcceptButton = btnOK;

        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Time = this.txtTime.Text;
            this.Instruction = this.cbboxInstruction.Text;
            this.KeyorCoordinate = this.txtKeyorCoordinate.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void _ascii_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKeyorCoordinate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _ascii.Text = "";
                _ascii.Text += (char)Int32.Parse(txtKeyorCoordinate.Text);
            }
            catch
            { }
        }


        public void edittxt(string str1, string str2, string str3)
        {
            this.txtTime.Text = str1;
            this.cbboxInstruction.Text = str2;
            this.txtKeyorCoordinate.Text = str3;
        }
    }
}
