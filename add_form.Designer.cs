namespace recall
{
    partial class add_form
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
            this.addbutton = new System.Windows.Forms.Button();
            this.typetext = new System.Windows.Forms.TextBox();
            this.titletwo = new System.Windows.Forms.RichTextBox();
            this.source = new System.Windows.Forms.TextBox();
            this.instime = new System.Windows.Forms.TextBox();
            this.titleone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(773, 529);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(137, 36);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "button1";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // typetext
            // 
            this.typetext.Location = new System.Drawing.Point(683, 445);
            this.typetext.Name = "typetext";
            this.typetext.Size = new System.Drawing.Size(160, 23);
            this.typetext.TabIndex = 2;
            // 
            // titletwo
            // 
            this.titletwo.Location = new System.Drawing.Point(12, 41);
            this.titletwo.Name = "titletwo";
            this.titletwo.Size = new System.Drawing.Size(1435, 398);
            this.titletwo.TabIndex = 3;
            this.titletwo.Text = "";
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(12, 445);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(665, 23);
            this.source.TabIndex = 4;
            // 
            // instime
            // 
            this.instime.Location = new System.Drawing.Point(849, 445);
            this.instime.Name = "instime";
            this.instime.Size = new System.Drawing.Size(145, 23);
            this.instime.TabIndex = 5;
            // 
            // titleone
            // 
            this.titleone.Location = new System.Drawing.Point(12, 12);
            this.titleone.Name = "titleone";
            this.titleone.Size = new System.Drawing.Size(1414, 23);
            this.titleone.TabIndex = 6;
            this.titleone.TextChanged += new System.EventHandler(this.titleone_TextChanged);
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 639);
            this.Controls.Add(this.titleone);
            this.Controls.Add(this.instime);
            this.Controls.Add(this.source);
            this.Controls.Add(this.titletwo);
            this.Controls.Add(this.typetext);
            this.Controls.Add(this.addbutton);
            this.Name = "add_form";
            this.Text = "add_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addbutton;
        private TextBox typetext;
        private RichTextBox titletwo;
        private TextBox source;
        private TextBox instime;
        private TextBox titleone;
    }
}