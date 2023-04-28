namespace Shadowplay_Mic_Fix_GUI
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
            this.createTaskBtn = new System.Windows.Forms.Button();
            this.deleteTaskBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.micComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createTaskBtn
            // 
            this.createTaskBtn.Location = new System.Drawing.Point(12, 12);
            this.createTaskBtn.Name = "createTaskBtn";
            this.createTaskBtn.Size = new System.Drawing.Size(111, 23);
            this.createTaskBtn.TabIndex = 0;
            this.createTaskBtn.Text = "Create Startup Task";
            this.createTaskBtn.UseVisualStyleBackColor = true;
            this.createTaskBtn.Click += new System.EventHandler(this.createTaskBtn_Click);
            // 
            // deleteTaskBtn
            // 
            this.deleteTaskBtn.Location = new System.Drawing.Point(129, 12);
            this.deleteTaskBtn.Name = "deleteTaskBtn";
            this.deleteTaskBtn.Size = new System.Drawing.Size(113, 23);
            this.deleteTaskBtn.TabIndex = 1;
            this.deleteTaskBtn.Text = "Delete Startup Task";
            this.deleteTaskBtn.UseVisualStyleBackColor = true;
            this.deleteTaskBtn.Click += new System.EventHandler(this.deleteTaskBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(89, 68);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // micComboBox
            // 
            this.micComboBox.FormattingEnabled = true;
            this.micComboBox.Location = new System.Drawing.Point(12, 41);
            this.micComboBox.Name = "micComboBox";
            this.micComboBox.Size = new System.Drawing.Size(230, 21);
            this.micComboBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 99);
            this.Controls.Add(this.micComboBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteTaskBtn);
            this.Controls.Add(this.createTaskBtn);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Shadowplay Mic Fix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createTaskBtn;
        private System.Windows.Forms.Button deleteTaskBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox micComboBox;
    }
}