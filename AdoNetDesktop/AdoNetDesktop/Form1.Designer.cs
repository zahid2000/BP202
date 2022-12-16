namespace AdoNetDesktop
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
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UserListDGRView = new System.Windows.Forms.DataGridView();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.AgeValue = new System.Windows.Forms.NumericUpDown();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserListDGRView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(583, 29);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 42);
            this.InsertBtn.TabIndex = 0;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UserListDGRView
            // 
            this.UserListDGRView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListDGRView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserListDGRView.Location = new System.Drawing.Point(0, 242);
            this.UserListDGRView.Name = "UserListDGRView";
            this.UserListDGRView.RowHeadersWidth = 51;
            this.UserListDGRView.RowTemplate.Height = 24;
            this.UserListDGRView.Size = new System.Drawing.Size(931, 272);
            this.UserListDGRView.TabIndex = 1;
            this.UserListDGRView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListDGRView_CellClick);
            this.UserListDGRView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListDGRView_CellDoubleClick);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(130, 29);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(186, 22);
            this.NameTxt.TabIndex = 2;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(130, 78);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(186, 22);
            this.SurnameTxt.TabIndex = 3;
            // 
            // AgeValue
            // 
            this.AgeValue.Location = new System.Drawing.Point(130, 132);
            this.AgeValue.Name = "AgeValue";
            this.AgeValue.Size = new System.Drawing.Size(186, 22);
            this.AgeValue.TabIndex = 4;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(29, 34);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(583, 84);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 42);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(583, 138);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 42);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 514);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AgeValue);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.UserListDGRView);
            this.Controls.Add(this.InsertBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserListDGRView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.DataGridView UserListDGRView;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.NumericUpDown AgeValue;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
    }
}

