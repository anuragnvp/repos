namespace Reflection
{
    partial class Form1
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
            this.textTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listmethods = new System.Windows.Forms.ListBox();
            this.listproperties = new System.Windows.Forms.ListBox();
            this.listconstructors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textTypeName
            // 
            this.textTypeName.Location = new System.Drawing.Point(155, 12);
            this.textTypeName.Name = "textTypeName";
            this.textTypeName.Size = new System.Drawing.Size(148, 20);
            this.textTypeName.TabIndex = 0;
            this.textTypeName.TextChanged += new System.EventHandler(this.textTypeName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a Class";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listmethods
            // 
            this.listmethods.FormattingEnabled = true;
            this.listmethods.Location = new System.Drawing.Point(15, 80);
            this.listmethods.Name = "listmethods";
            this.listmethods.Size = new System.Drawing.Size(186, 225);
            this.listmethods.TabIndex = 3;
            this.listmethods.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listproperties
            // 
            this.listproperties.FormattingEnabled = true;
            this.listproperties.Location = new System.Drawing.Point(246, 80);
            this.listproperties.Name = "listproperties";
            this.listproperties.Size = new System.Drawing.Size(199, 225);
            this.listproperties.TabIndex = 4;
            // 
            // listconstructors
            // 
            this.listconstructors.FormattingEnabled = true;
            this.listconstructors.Location = new System.Drawing.Point(532, 80);
            this.listconstructors.Name = "listconstructors";
            this.listconstructors.Size = new System.Drawing.Size(192, 225);
            this.listconstructors.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 331);
            this.Controls.Add(this.listconstructors);
            this.Controls.Add(this.listproperties);
            this.Controls.Add(this.listmethods);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTypeName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listmethods;
        private System.Windows.Forms.ListBox listproperties;
        private System.Windows.Forms.ListBox listconstructors;
    }
}

