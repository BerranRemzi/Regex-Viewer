namespace Regex_Viewer
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
			this.txtInput = new System.Windows.Forms.RichTextBox();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.RichTextBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(12, 65);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(450, 574);
			this.txtInput.TabIndex = 0;
			this.txtInput.Text = "";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(65, 13);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(773, 20);
			this.txtPath.TabIndex = 1;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(844, 11);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 2;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(468, 65);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(450, 574);
			this.txtResult.TabIndex = 3;
			this.txtResult.Text = "";
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(65, 39);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(773, 20);
			this.txtFilter.TabIndex = 4;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Input file";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Regex";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 650);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.txtInput);
			this.Name = "Form1";
			this.Text = "Regex Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtInput;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.RichTextBox txtResult;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

