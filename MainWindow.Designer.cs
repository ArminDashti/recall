namespace recall
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.titletwo = new System.Windows.Forms.RichTextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.source_recall_form = new System.Windows.Forms.TextBox();
            this.type_recall_form = new System.Windows.Forms.TextBox();
            this.list_form_recall = new System.Windows.Forms.Button();
            this.search_form_recall = new System.Windows.Forms.Button();
            this.filter_type_form_recall = new System.Windows.Forms.TextBox();
            this.id_form_recall = new System.Windows.Forms.TextBox();
            this.update_form_recall = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1097, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titletwo
            // 
            this.titletwo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titletwo.Location = new System.Drawing.Point(12, 162);
            this.titletwo.Name = "titletwo";
            this.titletwo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titletwo.Size = new System.Drawing.Size(1202, 383);
            this.titletwo.TabIndex = 4;
            this.titletwo.Text = "";
            this.titletwo.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(12, 37);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(104, 37);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(851, 37);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(117, 37);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // source_recall_form
            // 
            this.source_recall_form.Location = new System.Drawing.Point(12, 551);
            this.source_recall_form.Name = "source_recall_form";
            this.source_recall_form.Size = new System.Drawing.Size(1014, 23);
            this.source_recall_form.TabIndex = 9;
            // 
            // type_recall_form
            // 
            this.type_recall_form.Location = new System.Drawing.Point(1032, 551);
            this.type_recall_form.Name = "type_recall_form";
            this.type_recall_form.Size = new System.Drawing.Size(182, 23);
            this.type_recall_form.TabIndex = 10;
            // 
            // list_form_recall
            // 
            this.list_form_recall.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_form_recall.Location = new System.Drawing.Point(229, 37);
            this.list_form_recall.Name = "list_form_recall";
            this.list_form_recall.Size = new System.Drawing.Size(103, 37);
            this.list_form_recall.TabIndex = 11;
            this.list_form_recall.Text = "List";
            this.list_form_recall.UseVisualStyleBackColor = true;
            // 
            // search_form_recall
            // 
            this.search_form_recall.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_form_recall.Location = new System.Drawing.Point(122, 37);
            this.search_form_recall.Name = "search_form_recall";
            this.search_form_recall.Size = new System.Drawing.Size(101, 37);
            this.search_form_recall.TabIndex = 12;
            this.search_form_recall.Text = "Search";
            this.search_form_recall.UseVisualStyleBackColor = true;
            // 
            // filter_type_form_recall
            // 
            this.filter_type_form_recall.Location = new System.Drawing.Point(12, 580);
            this.filter_type_form_recall.Name = "filter_type_form_recall";
            this.filter_type_form_recall.Size = new System.Drawing.Size(1014, 23);
            this.filter_type_form_recall.TabIndex = 13;
            // 
            // id_form_recall
            // 
            this.id_form_recall.Location = new System.Drawing.Point(1032, 580);
            this.id_form_recall.Name = "id_form_recall";
            this.id_form_recall.ReadOnly = true;
            this.id_form_recall.Size = new System.Drawing.Size(182, 23);
            this.id_form_recall.TabIndex = 14;
            // 
            // update_form_recall
            // 
            this.update_form_recall.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_form_recall.Location = new System.Drawing.Point(974, 37);
            this.update_form_recall.Name = "update_form_recall";
            this.update_form_recall.Size = new System.Drawing.Size(117, 37);
            this.update_form_recall.TabIndex = 15;
            this.update_form_recall.Text = "Update";
            this.update_form_recall.UseVisualStyleBackColor = false;
            this.update_form_recall.Click += new System.EventHandler(this.update_form_recall_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTextBox.Location = new System.Drawing.Point(12, 80);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleTextBox.Size = new System.Drawing.Size(1202, 76);
            this.titleTextBox.TabIndex = 18;
            this.titleTextBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 613);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.update_form_recall);
            this.Controls.Add(this.id_form_recall);
            this.Controls.Add(this.filter_type_form_recall);
            this.Controls.Add(this.search_form_recall);
            this.Controls.Add(this.list_form_recall);
            this.Controls.Add(this.type_recall_form);
            this.Controls.Add(this.source_recall_form);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.titletwo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recall";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RichTextBox titletwo;
        private Button add;
        private Button delete;
        private TextBox source_recall_form;
        private TextBox type_recall_form;
        private Button list_form_recall;
        private Button search_form_recall;
        private TextBox filter_type_form_recall;
        private TextBox id_form_recall;
        private Button update_form_recall;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private RichTextBox titleTextBox;
    }
}