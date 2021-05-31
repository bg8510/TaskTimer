namespace TaskTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1Description = new System.Windows.Forms.TextBox();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.btnStopContinue1 = new System.Windows.Forms.Button();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnStopContinue2 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.timer2Description = new System.Windows.Forms.TextBox();
            this.btnReset3 = new System.Windows.Forms.Button();
            this.btnStopContinue3 = new System.Windows.Forms.Button();
            this.btnStart3 = new System.Windows.Forms.Button();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.timer3Description = new System.Windows.Forms.TextBox();
            this.btnReset4 = new System.Windows.Forms.Button();
            this.btnStopContinue4 = new System.Windows.Forms.Button();
            this.btnStart4 = new System.Windows.Forms.Button();
            this.lblTime4 = new System.Windows.Forms.Label();
            this.timer4Description = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1Description
            // 
            this.timer1Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timer1Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer1Description.Location = new System.Drawing.Point(26, 62);
            this.timer1Description.Name = "timer1Description";
            this.timer1Description.Size = new System.Drawing.Size(329, 27);
            this.timer1Description.TabIndex = 0;
            // 
            // lblTime1
            // 
            this.lblTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime1.AutoSize = true;
            this.lblTime1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.lblTime1.Location = new System.Drawing.Point(375, 66);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(34, 19);
            this.lblTime1.TabIndex = 1;
            this.lblTime1.Text = "0.0";
            // 
            // btnStart1
            // 
            this.btnStart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnStart1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart1.ForeColor = System.Drawing.Color.White;
            this.btnStart1.Location = new System.Drawing.Point(437, 58);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(63, 35);
            this.btnStart1.TabIndex = 2;
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = false;
            this.btnStart1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStopContinue1
            // 
            this.btnStopContinue1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopContinue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnStopContinue1.Enabled = false;
            this.btnStopContinue1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopContinue1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopContinue1.ForeColor = System.Drawing.Color.White;
            this.btnStopContinue1.Location = new System.Drawing.Point(507, 58);
            this.btnStopContinue1.Name = "btnStopContinue1";
            this.btnStopContinue1.Size = new System.Drawing.Size(89, 35);
            this.btnStopContinue1.TabIndex = 3;
            this.btnStopContinue1.Text = "Pause";
            this.btnStopContinue1.UseVisualStyleBackColor = false;
            this.btnStopContinue1.Click += new System.EventHandler(this.btnStopContinue_Click);
            // 
            // btnReset1
            // 
            this.btnReset1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnReset1.Enabled = false;
            this.btnReset1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset1.ForeColor = System.Drawing.Color.White;
            this.btnReset1.Location = new System.Drawing.Point(602, 58);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(73, 35);
            this.btnReset1.TabIndex = 4;
            this.btnReset1.Text = "Reset";
            this.btnReset1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReset1.UseVisualStyleBackColor = false;
            this.btnReset1.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnReset2.Enabled = false;
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.ForeColor = System.Drawing.Color.White;
            this.btnReset2.Location = new System.Drawing.Point(602, 104);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(73, 35);
            this.btnReset2.TabIndex = 9;
            this.btnReset2.Text = "Reset";
            this.btnReset2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnStopContinue2
            // 
            this.btnStopContinue2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopContinue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnStopContinue2.Enabled = false;
            this.btnStopContinue2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopContinue2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopContinue2.ForeColor = System.Drawing.Color.White;
            this.btnStopContinue2.Location = new System.Drawing.Point(507, 104);
            this.btnStopContinue2.Name = "btnStopContinue2";
            this.btnStopContinue2.Size = new System.Drawing.Size(89, 35);
            this.btnStopContinue2.TabIndex = 8;
            this.btnStopContinue2.Text = "Pause";
            this.btnStopContinue2.UseVisualStyleBackColor = false;
            this.btnStopContinue2.Click += new System.EventHandler(this.btnStopContinue2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnStart2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart2.ForeColor = System.Drawing.Color.White;
            this.btnStart2.Location = new System.Drawing.Point(437, 104);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(63, 35);
            this.btnStart2.TabIndex = 7;
            this.btnStart2.Text = "Start";
            this.btnStart2.UseVisualStyleBackColor = false;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // lblTime2
            // 
            this.lblTime2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime2.AutoSize = true;
            this.lblTime2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.lblTime2.Location = new System.Drawing.Point(375, 112);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(34, 19);
            this.lblTime2.TabIndex = 6;
            this.lblTime2.Text = "0.0";
            // 
            // timer2Description
            // 
            this.timer2Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timer2Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer2Description.Location = new System.Drawing.Point(26, 108);
            this.timer2Description.Name = "timer2Description";
            this.timer2Description.Size = new System.Drawing.Size(329, 27);
            this.timer2Description.TabIndex = 5;
            // 
            // btnReset3
            // 
            this.btnReset3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnReset3.Enabled = false;
            this.btnReset3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset3.ForeColor = System.Drawing.Color.White;
            this.btnReset3.Location = new System.Drawing.Point(602, 150);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(73, 35);
            this.btnReset3.TabIndex = 14;
            this.btnReset3.Text = "Reset";
            this.btnReset3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReset3.UseVisualStyleBackColor = false;
            this.btnReset3.Click += new System.EventHandler(this.btnReset3_Click);
            // 
            // btnStopContinue3
            // 
            this.btnStopContinue3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopContinue3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnStopContinue3.Enabled = false;
            this.btnStopContinue3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopContinue3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopContinue3.ForeColor = System.Drawing.Color.White;
            this.btnStopContinue3.Location = new System.Drawing.Point(507, 150);
            this.btnStopContinue3.Name = "btnStopContinue3";
            this.btnStopContinue3.Size = new System.Drawing.Size(89, 35);
            this.btnStopContinue3.TabIndex = 13;
            this.btnStopContinue3.Text = "Pause";
            this.btnStopContinue3.UseVisualStyleBackColor = false;
            this.btnStopContinue3.Click += new System.EventHandler(this.btnStopContinue3_Click);
            // 
            // btnStart3
            // 
            this.btnStart3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnStart3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart3.ForeColor = System.Drawing.Color.White;
            this.btnStart3.Location = new System.Drawing.Point(437, 150);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(63, 35);
            this.btnStart3.TabIndex = 12;
            this.btnStart3.Text = "Start";
            this.btnStart3.UseVisualStyleBackColor = false;
            this.btnStart3.Click += new System.EventHandler(this.btnStart3_Click);
            // 
            // lblTime3
            // 
            this.lblTime3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime3.AutoSize = true;
            this.lblTime3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.lblTime3.Location = new System.Drawing.Point(375, 158);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(34, 19);
            this.lblTime3.TabIndex = 11;
            this.lblTime3.Text = "0.0";
            // 
            // timer3Description
            // 
            this.timer3Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timer3Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer3Description.Location = new System.Drawing.Point(26, 154);
            this.timer3Description.Name = "timer3Description";
            this.timer3Description.Size = new System.Drawing.Size(329, 27);
            this.timer3Description.TabIndex = 10;
            // 
            // btnReset4
            // 
            this.btnReset4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnReset4.Enabled = false;
            this.btnReset4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset4.ForeColor = System.Drawing.Color.White;
            this.btnReset4.Location = new System.Drawing.Point(602, 195);
            this.btnReset4.Name = "btnReset4";
            this.btnReset4.Size = new System.Drawing.Size(73, 35);
            this.btnReset4.TabIndex = 19;
            this.btnReset4.Text = "Reset";
            this.btnReset4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReset4.UseVisualStyleBackColor = false;
            this.btnReset4.Click += new System.EventHandler(this.btnReset4_Click);
            // 
            // btnStopContinue4
            // 
            this.btnStopContinue4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopContinue4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnStopContinue4.Enabled = false;
            this.btnStopContinue4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopContinue4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopContinue4.ForeColor = System.Drawing.Color.White;
            this.btnStopContinue4.Location = new System.Drawing.Point(507, 195);
            this.btnStopContinue4.Name = "btnStopContinue4";
            this.btnStopContinue4.Size = new System.Drawing.Size(89, 35);
            this.btnStopContinue4.TabIndex = 18;
            this.btnStopContinue4.Text = "Pause";
            this.btnStopContinue4.UseVisualStyleBackColor = false;
            this.btnStopContinue4.Click += new System.EventHandler(this.btnStopContinue4_Click);
            // 
            // btnStart4
            // 
            this.btnStart4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.btnStart4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart4.ForeColor = System.Drawing.Color.White;
            this.btnStart4.Location = new System.Drawing.Point(437, 195);
            this.btnStart4.Name = "btnStart4";
            this.btnStart4.Size = new System.Drawing.Size(63, 35);
            this.btnStart4.TabIndex = 17;
            this.btnStart4.Text = "Start";
            this.btnStart4.UseVisualStyleBackColor = false;
            this.btnStart4.Click += new System.EventHandler(this.btnStart4_Click);
            // 
            // lblTime4
            // 
            this.lblTime4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime4.AutoSize = true;
            this.lblTime4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.lblTime4.Location = new System.Drawing.Point(375, 203);
            this.lblTime4.Name = "lblTime4";
            this.lblTime4.Size = new System.Drawing.Size(34, 19);
            this.lblTime4.TabIndex = 16;
            this.lblTime4.Text = "0.0";
            // 
            // timer4Description
            // 
            this.timer4Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timer4Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer4Description.Location = new System.Drawing.Point(26, 198);
            this.timer4Description.Name = "timer4Description";
            this.timer4Description.Size = new System.Drawing.Size(329, 27);
            this.timer4Description.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(100, 15);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 35);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Tasks";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(711, 243);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnReset4);
            this.Controls.Add(this.btnStopContinue4);
            this.Controls.Add(this.btnStart4);
            this.Controls.Add(this.lblTime4);
            this.Controls.Add(this.timer4Description);
            this.Controls.Add(this.btnReset3);
            this.Controls.Add(this.btnStopContinue3);
            this.Controls.Add(this.btnStart3);
            this.Controls.Add(this.lblTime3);
            this.Controls.Add(this.timer3Description);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.btnStopContinue2);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.timer2Description);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.btnStopContinue1);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.timer1Description);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Task Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timer1Description;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Button btnStopContinue1;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnStopContinue2;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.TextBox timer2Description;
        private System.Windows.Forms.Button btnReset3;
        private System.Windows.Forms.Button btnStopContinue3;
        private System.Windows.Forms.Button btnStart3;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.TextBox timer3Description;
        private System.Windows.Forms.Button btnReset4;
        private System.Windows.Forms.Button btnStopContinue4;
        private System.Windows.Forms.Button btnStart4;
        private System.Windows.Forms.Label lblTime4;
        private System.Windows.Forms.TextBox timer4Description;
        private System.Windows.Forms.Label lblDescription;
    }
}

