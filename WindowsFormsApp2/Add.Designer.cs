namespace WindowsFormsApp2
{
    partial class Add1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add1));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.food = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(51, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "喜爱的食物：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(51, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "重量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(51, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "颜色：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(51, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "种类：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(51, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "名字：";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(138, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 14;
            // 
            // food
            // 
            this.food.Location = new System.Drawing.Point(138, 246);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(100, 21);
            this.food.TabIndex = 11;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(138, 190);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 21);
            this.weight.TabIndex = 12;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(138, 149);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(100, 21);
            this.color.TabIndex = 13;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "猫",
            "狗",
            "鸟"});
            this.type.Location = new System.Drawing.Point(138, 63);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 20);
            this.type.TabIndex = 20;
            this.type.SelectedIndexChanged += new System.EventHandler(this.speciesComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(274, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.food);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.color);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add1";
            this.Text = "添加宠物";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox food;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Button button1;
    }
}