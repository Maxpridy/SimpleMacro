namespace SimpleMacro
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProgromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMacro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSimpleMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._txtHello = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgromToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProgromToolStripMenuItem
            // 
            this.ProgromToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMacro,
            this.toolStripMenuItem2,
            this.menuExit});
            this.ProgromToolStripMenuItem.Name = "ProgromToolStripMenuItem";
            this.ProgromToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ProgromToolStripMenuItem.Text = "Program";
            // 
            // menuMacro
            // 
            this.menuMacro.Name = "menuMacro";
            this.menuMacro.Size = new System.Drawing.Size(152, 22);
            this.menuMacro.Text = "Macro";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "?";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSimpleMacroToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutSimpleMacroToolStripMenuItem
            // 
            this.aboutSimpleMacroToolStripMenuItem.Name = "aboutSimpleMacroToolStripMenuItem";
            this.aboutSimpleMacroToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aboutSimpleMacroToolStripMenuItem.Text = "About SimpleMacro..";
            this.aboutSimpleMacroToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // _txtHello
            // 
            this._txtHello.AutoSize = true;
            this._txtHello.Font = new System.Drawing.Font("Gulim", 30F);
            this._txtHello.Location = new System.Drawing.Point(120, 95);
            this._txtHello.Name = "_txtHello";
            this._txtHello.Size = new System.Drawing.Size(124, 40);
            this._txtHello.TabIndex = 2;
            this._txtHello.Text = "Hello!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 219);
            this.Controls.Add(this._txtHello);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SimpleMacro 1.0.3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProgromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMacro;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label _txtHello;
        private System.Windows.Forms.ToolStripMenuItem aboutSimpleMacroToolStripMenuItem;
    }
}

