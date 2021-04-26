
namespace HomeWork6
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private FormAddorDel form2 = new FormAddorDel();
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.addOrder = new System.Windows.Forms.Button();
            this.delOrder = new System.Windows.Forms.Button();
            this.chaOrder = new System.Windows.Forms.Button();
            this.seaOrder = new System.Windows.Forms.Button();
            this.shoOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(310, 44);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(149, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "欢迎使用本系统";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // addOrder
            // 
            this.addOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addOrder.Location = new System.Drawing.Point(314, 114);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(127, 23);
            this.addOrder.TabIndex = 1;
            this.addOrder.Text = "1. 添加订单";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // delOrder
            // 
            this.delOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delOrder.Location = new System.Drawing.Point(314, 172);
            this.delOrder.Name = "delOrder";
            this.delOrder.Size = new System.Drawing.Size(127, 23);
            this.delOrder.TabIndex = 2;
            this.delOrder.Text = "2. 删除订单";
            this.delOrder.UseVisualStyleBackColor = true;
            this.delOrder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chaOrder
            // 
            this.chaOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chaOrder.Location = new System.Drawing.Point(314, 228);
            this.chaOrder.Name = "chaOrder";
            this.chaOrder.Size = new System.Drawing.Size(127, 23);
            this.chaOrder.TabIndex = 3;
            this.chaOrder.Text = "3. 修改订单";
            this.chaOrder.UseVisualStyleBackColor = true;
            // 
            // seaOrder
            // 
            this.seaOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seaOrder.Location = new System.Drawing.Point(314, 285);
            this.seaOrder.Name = "seaOrder";
            this.seaOrder.Size = new System.Drawing.Size(127, 23);
            this.seaOrder.TabIndex = 4;
            this.seaOrder.Text = "4. 查询订单";
            this.seaOrder.UseVisualStyleBackColor = true;
            this.seaOrder.Click += new System.EventHandler(this.button3_Click);
            // 
            // shoOrder
            // 
            this.shoOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shoOrder.Location = new System.Drawing.Point(314, 338);
            this.shoOrder.Name = "shoOrder";
            this.shoOrder.Size = new System.Drawing.Size(127, 23);
            this.shoOrder.TabIndex = 5;
            this.shoOrder.Text = "5. 显示订单";
            this.shoOrder.UseVisualStyleBackColor = true;
            this.shoOrder.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shoOrder);
            this.Controls.Add(this.seaOrder);
            this.Controls.Add(this.chaOrder);
            this.Controls.Add(this.delOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.Title);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.Text = "OrderService";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button delOrder;
        private System.Windows.Forms.Button chaOrder;
        private System.Windows.Forms.Button seaOrder;
        private System.Windows.Forms.Button shoOrder;
    }
}

