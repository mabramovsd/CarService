namespace WindowsFormsApp11
{
    partial class FIlterForm
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
            this.maxPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.minPriceTextBox = new System.Windows.Forms.TextBox();
            this.factoryCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxPriceTextBox
            // 
            this.maxPriceTextBox.Location = new System.Drawing.Point(100, 23);
            this.maxPriceTextBox.Name = "maxPriceTextBox";
            this.maxPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.maxPriceTextBox.TabIndex = 0;
            this.maxPriceTextBox.TextChanged += new System.EventHandler(this.maxPriceTextBox_TextChanged);
            this.maxPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maxPriceTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Макс. цена";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Мин. цена";
            // 
            // minPriceTextBox
            // 
            this.minPriceTextBox.Location = new System.Drawing.Point(100, 51);
            this.minPriceTextBox.Name = "minPriceTextBox";
            this.minPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.minPriceTextBox.TabIndex = 3;
            this.minPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maxPriceTextBox_KeyDown);
            // 
            // factoryCheckedListBox
            // 
            this.factoryCheckedListBox.FormattingEnabled = true;
            this.factoryCheckedListBox.Items.AddRange(new object[] {
            "VAZ",
            "KIA",
            "Pagani"});
            this.factoryCheckedListBox.Location = new System.Drawing.Point(100, 80);
            this.factoryCheckedListBox.Name = "factoryCheckedListBox";
            this.factoryCheckedListBox.Size = new System.Drawing.Size(100, 89);
            this.factoryCheckedListBox.TabIndex = 5;
            this.factoryCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Завод";
            // 
            // FIlterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.factoryCheckedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minPriceTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxPriceTextBox);
            this.Name = "FIlterForm";
            this.Text = "FIlterForm";
            this.Load += new System.EventHandler(this.FIlterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minPriceTextBox;
        private System.Windows.Forms.CheckedListBox factoryCheckedListBox;
        private System.Windows.Forms.Label label3;
    }
}