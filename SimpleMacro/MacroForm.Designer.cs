namespace SimpleMacro
{
    partial class MacroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroForm));
            this.Macro_InputFromSystem = new System.Windows.Forms.Button();
            this.Macro_Addmacro = new System.Windows.Forms.Button();
            this.Macro_Editmacro = new System.Windows.Forms.Button();
            this.Macro_Deletemacro = new System.Windows.Forms.Button();
            this.Macro_Functionmacro = new System.Windows.Forms.Button();
            this.Macro_Playmacro = new System.Windows.Forms.Button();
            this.Macro_Closemacro = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.Macro_Macrodata = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Macro_btnDeleteData = new System.Windows.Forms.Button();
            this._Repeat_Count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Macro_InputFromSystem
            // 
            resources.ApplyResources(this.Macro_InputFromSystem, "Macro_InputFromSystem");
            this.Macro_InputFromSystem.Name = "Macro_InputFromSystem";
            this.Macro_InputFromSystem.UseVisualStyleBackColor = true;
            this.Macro_InputFromSystem.Click += new System.EventHandler(this.Macro_InputFromSystem_Click);
            // 
            // Macro_Addmacro
            // 
            resources.ApplyResources(this.Macro_Addmacro, "Macro_Addmacro");
            this.Macro_Addmacro.Name = "Macro_Addmacro";
            this.Macro_Addmacro.UseVisualStyleBackColor = true;
            this.Macro_Addmacro.Click += new System.EventHandler(this.Macro_Addmacro_Click);
            // 
            // Macro_Editmacro
            // 
            resources.ApplyResources(this.Macro_Editmacro, "Macro_Editmacro");
            this.Macro_Editmacro.Name = "Macro_Editmacro";
            this.Macro_Editmacro.UseVisualStyleBackColor = true;
            this.Macro_Editmacro.Click += new System.EventHandler(this.Macro_Editmacro_Click);
            // 
            // Macro_Deletemacro
            // 
            resources.ApplyResources(this.Macro_Deletemacro, "Macro_Deletemacro");
            this.Macro_Deletemacro.Name = "Macro_Deletemacro";
            this.Macro_Deletemacro.UseVisualStyleBackColor = true;
            this.Macro_Deletemacro.Click += new System.EventHandler(this.Macro_Deletemacro_Click);
            // 
            // Macro_Functionmacro
            // 
            resources.ApplyResources(this.Macro_Functionmacro, "Macro_Functionmacro");
            this.Macro_Functionmacro.Name = "Macro_Functionmacro";
            this.Macro_Functionmacro.UseVisualStyleBackColor = true;
            this.Macro_Functionmacro.Click += new System.EventHandler(this.Macro_Functionmacro_Click);
            // 
            // Macro_Playmacro
            // 
            resources.ApplyResources(this.Macro_Playmacro, "Macro_Playmacro");
            this.Macro_Playmacro.Name = "Macro_Playmacro";
            this.Macro_Playmacro.UseVisualStyleBackColor = true;
            this.Macro_Playmacro.Click += new System.EventHandler(this.Macro_Playmacro_Click);
            // 
            // Macro_Closemacro
            // 
            resources.ApplyResources(this.Macro_Closemacro, "Macro_Closemacro");
            this.Macro_Closemacro.Name = "Macro_Closemacro";
            this.Macro_Closemacro.UseVisualStyleBackColor = true;
            this.Macro_Closemacro.Click += new System.EventHandler(this.Macro_Closemacro_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Macro_Macrodata
            // 
            this.Macro_Macrodata.CheckBoxes = true;
            this.Macro_Macrodata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Macro_Macrodata.FullRowSelect = true;
            this.Macro_Macrodata.GridLines = true;
            resources.ApplyResources(this.Macro_Macrodata, "Macro_Macrodata");
            this.Macro_Macrodata.Name = "Macro_Macrodata";
            this.Macro_Macrodata.UseCompatibleStateImageBehavior = false;
            this.Macro_Macrodata.View = System.Windows.Forms.View.Details;
            this.Macro_Macrodata.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // Macro_btnDeleteData
            // 
            resources.ApplyResources(this.Macro_btnDeleteData, "Macro_btnDeleteData");
            this.Macro_btnDeleteData.Name = "Macro_btnDeleteData";
            this.Macro_btnDeleteData.UseVisualStyleBackColor = true;
            this.Macro_btnDeleteData.Click += new System.EventHandler(this.Macro_btnDeleteData_Click);
            // 
            // _Repeat_Count
            // 
            resources.ApplyResources(this._Repeat_Count, "_Repeat_Count");
            this._Repeat_Count.Name = "_Repeat_Count";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // MacroForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._Repeat_Count);
            this.Controls.Add(this.Macro_btnDeleteData);
            this.Controls.Add(this.Macro_Macrodata);
            this.Controls.Add(this.Macro_Closemacro);
            this.Controls.Add(this.Macro_Playmacro);
            this.Controls.Add(this.Macro_Functionmacro);
            this.Controls.Add(this.Macro_Deletemacro);
            this.Controls.Add(this.Macro_Editmacro);
            this.Controls.Add(this.Macro_Addmacro);
            this.Controls.Add(this.Macro_InputFromSystem);
            this.Name = "MacroForm";
            this.Load += new System.EventHandler(this.MacroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Macro_InputFromSystem;
        private System.Windows.Forms.Button Macro_Addmacro;
        private System.Windows.Forms.Button Macro_Editmacro;
        private System.Windows.Forms.Button Macro_Deletemacro;
        private System.Windows.Forms.Button Macro_Functionmacro;
        private System.Windows.Forms.Button Macro_Playmacro;
        private System.Windows.Forms.Button Macro_Closemacro;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ListView Macro_Macrodata;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button Macro_btnDeleteData;
        private System.Windows.Forms.TextBox _Repeat_Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private int _count;
        private int _stop_flag;
    }
}