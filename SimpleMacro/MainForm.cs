using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SimpleMacro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.menuMacro.Click += menuMacro_Click;
            this.menuExit.Click += menuExit_Click;

        
        }
        
        void menuMacro_Click(object sender, EventArgs e)
        {
            MacroForm macForm = new MacroForm();
            macForm.Show();
        }


        void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }


    public class ReadOnlyTextBox : TextBox
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public ReadOnlyTextBox()
        {
            //this.ReadOnly = true;
            this.BackColor = Color.White;
            this.GotFocus += TextBoxGotFocus;
            this.Cursor = Cursors.No; // mouse cursor like in other controls

        }

        private void TextBoxGotFocus(object sender, EventArgs args)
        {
           // HideCaret(this.Handle);
        }
    }
}
