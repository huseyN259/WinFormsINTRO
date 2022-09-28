namespace WinFormsIntro;

partial class Form1
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
			components.Dispose();
		
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.hsyn_nrn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// hsyn_nrn
			// 
			this.hsyn_nrn.BackColor = System.Drawing.SystemColors.HotTrack;
			this.hsyn_nrn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hsyn_nrn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.hsyn_nrn.Location = new System.Drawing.Point(578, 260);
			this.hsyn_nrn.Name = "hsyn_nrn";
			this.hsyn_nrn.Size = new System.Drawing.Size(195, 178);
			this.hsyn_nrn.TabIndex = 0;
			this.hsyn_nrn.Text = "hsyn_nrn";
			this.hsyn_nrn.UseVisualStyleBackColor = false;
			this.hsyn_nrn.Click += new System.EventHandler(this.hsyn_nrn_Click);
			this.hsyn_nrn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hsyn_nrn_MouseDown);
			this.hsyn_nrn.MouseEnter += new System.EventHandler(this.hsyn_nrn_MouseEnter);
			this.hsyn_nrn.MouseLeave += new System.EventHandler(this.hsyn_nrn_MouseLeave);
			this.hsyn_nrn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hsyn_nrn_MouseMove);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(671, 26);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(117, 24);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 105);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(178, 31);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(24, 52);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 29);
			this.button2.TabIndex = 4;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hsyn_nrn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private Button hsyn_nrn;
	private Label label1;
	private RadioButton radioButton1;
	private Button button1;
	private Button button2;
}