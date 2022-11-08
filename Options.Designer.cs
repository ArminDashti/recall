namespace recall
{
    partial class Options
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
            this.connectionStringText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectionStringText
            // 
            this.connectionStringText.Location = new System.Drawing.Point(12, 39);
            this.connectionStringText.Name = "connectionStringText";
            this.connectionStringText.Size = new System.Drawing.Size(496, 23);
            this.connectionStringText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection string :";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(12, 115);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(496, 34);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tabel name :";
            // 
            // tableNameText
            // 
            this.tableNameText.Location = new System.Drawing.Point(12, 86);
            this.tableNameText.Name = "tableNameText";
            this.tableNameText.Size = new System.Drawing.Size(496, 23);
            this.tableNameText.TabIndex = 3;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableNameText);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionStringText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox connectionStringText;
        private Label label1;
        private Button applyButton;
        private Label label2;
        private TextBox tableNameText;
    }
}