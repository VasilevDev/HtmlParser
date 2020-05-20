namespace HtmlParser
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.ListItemsView = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.StartPoint = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.EndPoint = new System.Windows.Forms.NumericUpDown();
			this.StartBtn = new System.Windows.Forms.Button();
			this.AbortBtn = new System.Windows.Forms.Button();
			this.ClearBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.StartPoint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EndPoint)).BeginInit();
			this.SuspendLayout();
			// 
			// ListItemsView
			// 
			this.ListItemsView.FormattingEnabled = true;
			this.ListItemsView.Location = new System.Drawing.Point(12, 12);
			this.ListItemsView.Name = "ListItemsView";
			this.ListItemsView.Size = new System.Drawing.Size(545, 420);
			this.ListItemsView.TabIndex = 0;
			this.ListItemsView.SelectedIndexChanged += new System.EventHandler(this.ListItemsView_SelectedIndexChanged);
			this.ListItemsView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListItemsView_MouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(560, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "StartPoint";
			// 
			// StartPoint
			// 
			this.StartPoint.Location = new System.Drawing.Point(563, 27);
			this.StartPoint.Name = "StartPoint";
			this.StartPoint.Size = new System.Drawing.Size(120, 20);
			this.StartPoint.TabIndex = 2;
			this.StartPoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(560, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "EndPoint";
			// 
			// EndPoint
			// 
			this.EndPoint.Location = new System.Drawing.Point(563, 66);
			this.EndPoint.Name = "EndPoint";
			this.EndPoint.Size = new System.Drawing.Size(120, 20);
			this.EndPoint.TabIndex = 4;
			this.EndPoint.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// StartBtn
			// 
			this.StartBtn.Location = new System.Drawing.Point(563, 108);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(120, 23);
			this.StartBtn.TabIndex = 5;
			this.StartBtn.Text = "Start";
			this.StartBtn.UseVisualStyleBackColor = true;
			this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// AbortBtn
			// 
			this.AbortBtn.Location = new System.Drawing.Point(563, 137);
			this.AbortBtn.Name = "AbortBtn";
			this.AbortBtn.Size = new System.Drawing.Size(120, 23);
			this.AbortBtn.TabIndex = 6;
			this.AbortBtn.Text = "Abort";
			this.AbortBtn.UseVisualStyleBackColor = true;
			this.AbortBtn.Click += new System.EventHandler(this.AbortBtn_Click);
			// 
			// ClearBtn
			// 
			this.ClearBtn.Location = new System.Drawing.Point(563, 167);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(120, 23);
			this.ClearBtn.TabIndex = 7;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 446);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.AbortBtn);
			this.Controls.Add(this.StartBtn);
			this.Controls.Add(this.EndPoint);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.StartPoint);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ListItemsView);
			this.Name = "Form1";
			this.Text = "HtmlParser";
			((System.ComponentModel.ISupportInitialize)(this.StartPoint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EndPoint)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ListItemsView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown StartPoint;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown EndPoint;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.Button AbortBtn;
		private System.Windows.Forms.Button ClearBtn;
	}
}

