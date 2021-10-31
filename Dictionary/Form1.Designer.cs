
namespace Dictionary
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
            this.label1 = new System.Windows.Forms.Label();
            this.wordList = new System.Windows.Forms.ListBox();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.combo_Search = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.word_ID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Word:";
            // 
            // wordList
            // 
            this.wordList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.wordList.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordList.FormattingEnabled = true;
            this.wordList.ItemHeight = 25;
            this.wordList.Location = new System.Drawing.Point(13, 218);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(430, 404);
            this.wordList.TabIndex = 2;
            this.wordList.TabStop = false;
            this.wordList.SelectedIndexChanged += new System.EventHandler(this.wordList_SelectedIndexChanged);
            // 
            // displayBox
            // 
            this.displayBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayBox.BackColor = System.Drawing.SystemColors.Window;
            this.displayBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.displayBox.Location = new System.Drawing.Point(463, 218);
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(732, 404);
            this.displayBox.TabIndex = 3;
            this.displayBox.TabStop = false;
            this.displayBox.Text = "";
            // 
            // combo_Search
            // 
            this.combo_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combo_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.combo_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.combo_Search.Font = new System.Drawing.Font("Segoe UI", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Search.ForeColor = System.Drawing.Color.White;
            this.combo_Search.FormattingEnabled = true;
            this.combo_Search.Location = new System.Drawing.Point(13, 174);
            this.combo_Search.Margin = new System.Windows.Forms.Padding(1);
            this.combo_Search.MaxDropDownItems = 5;
            this.combo_Search.Name = "combo_Search";
            this.combo_Search.Size = new System.Drawing.Size(430, 38);
            this.combo_Search.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.groupBox1.Controls.Add(this.word_ID);
            this.groupBox1.Controls.Add(this.combo_Search);
            this.groupBox1.Controls.Add(this.wordList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 635);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // word_ID
            // 
            this.word_ID.AutoSize = true;
            this.word_ID.Font = new System.Drawing.Font("Segoe UI", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word_ID.ForeColor = System.Drawing.Color.White;
            this.word_ID.Location = new System.Drawing.Point(459, 181);
            this.word_ID.Name = "word_ID";
            this.word_ID.Size = new System.Drawing.Size(34, 25);
            this.word_ID.TabIndex = 3;
            this.word_ID.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1207, 634);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wordList;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.ComboBox combo_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label word_ID;
    }
}

