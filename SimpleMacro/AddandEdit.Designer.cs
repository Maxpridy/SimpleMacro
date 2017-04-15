namespace SimpleMacro
{
    partial class AddandEdit
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
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtKeyorCoordinate = new System.Windows.Forms.TextBox();
            this._ascii = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbboxInstruction = new System.Windows.Forms.ComboBox();
            this._lblTime = new System.Windows.Forms.Label();
            this._lblInstruction = new System.Windows.Forms.Label();
            this._lblKeyorCoordinate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(38, 35);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 1;
            // 
            // txtKeyorCoordinate
            // 
            this.txtKeyorCoordinate.Location = new System.Drawing.Point(206, 93);
            this.txtKeyorCoordinate.Name = "txtKeyorCoordinate";
            this.txtKeyorCoordinate.Size = new System.Drawing.Size(96, 21);
            this.txtKeyorCoordinate.TabIndex = 3;
            this.txtKeyorCoordinate.TextChanged += new System.EventHandler(this.txtKeyorCoordinate_TextChanged);
            // 
            // _ascii
            // 
            this._ascii.BackColor = System.Drawing.SystemColors.Control;
            this._ascii.Enabled = false;
            this._ascii.Location = new System.Drawing.Point(308, 93);
            this._ascii.Name = "_ascii";
            this._ascii.Size = new System.Drawing.Size(48, 21);
            this._ascii.TabIndex = 4;
            this._ascii.TextChanged += new System.EventHandler(this._ascii_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(142, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 26);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbboxInstruction
            // 
            this.cbboxInstruction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxInstruction.FormattingEnabled = true;
            this.cbboxInstruction.Items.AddRange(new object[] {
            "마우스 왼쪽 버튼 누름",
            "마우스 왼쪽 버튼 뗌",
            "마우스 오른쪽 버튼 누름",
            "마우스 오른쪽 버튼 뗌",
            "마우스 이동",
            "키보드 누름",
            "키보드 뗌"});
            this.cbboxInstruction.Location = new System.Drawing.Point(38, 94);
            this.cbboxInstruction.Name = "cbboxInstruction";
            this.cbboxInstruction.Size = new System.Drawing.Size(154, 20);
            this.cbboxInstruction.TabIndex = 9;
            // 
            // _lblTime
            // 
            this._lblTime.AutoSize = true;
            this._lblTime.Location = new System.Drawing.Point(27, 20);
            this._lblTime.Name = "_lblTime";
            this._lblTime.Size = new System.Drawing.Size(64, 12);
            this._lblTime.TabIndex = 10;
            this._lblTime.Text = "Time(mili)";
            // 
            // _lblInstruction
            // 
            this._lblInstruction.AutoSize = true;
            this._lblInstruction.Location = new System.Drawing.Point(27, 79);
            this._lblInstruction.Name = "_lblInstruction";
            this._lblInstruction.Size = new System.Drawing.Size(63, 12);
            this._lblInstruction.TabIndex = 11;
            this._lblInstruction.Text = "Instruction";
            // 
            // _lblKeyorCoordinate
            // 
            this._lblKeyorCoordinate.AutoSize = true;
            this._lblKeyorCoordinate.Location = new System.Drawing.Point(183, 79);
            this._lblKeyorCoordinate.Name = "_lblKeyorCoordinate";
            this._lblKeyorCoordinate.Size = new System.Drawing.Size(67, 12);
            this._lblKeyorCoordinate.TabIndex = 12;
            this._lblKeyorCoordinate.Text = "Key/Coord";
            // 
            // AddandEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 186);
            this.Controls.Add(this._lblKeyorCoordinate);
            this.Controls.Add(this._lblInstruction);
            this.Controls.Add(this._lblTime);
            this.Controls.Add(this.cbboxInstruction);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this._ascii);
            this.Controls.Add(this.txtKeyorCoordinate);
            this.Controls.Add(this.txtTime);
            this.Name = "AddandEdit";
            this.Text = "AddandEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtKeyorCoordinate;
        private System.Windows.Forms.TextBox _ascii;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbboxInstruction;
        private System.Windows.Forms.Label _lblTime;
        private System.Windows.Forms.Label _lblInstruction;
        private System.Windows.Forms.Label _lblKeyorCoordinate;
    }
}