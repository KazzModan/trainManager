namespace TrainManager
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
            this.label2 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.atention = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(327, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(330, 177);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(100, 22);
            this.logBox.TabIndex = 2;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(330, 262);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 22);
            this.passBox.TabIndex = 3;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(312, 311);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(138, 35);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Sign in";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // atention
            // 
            this.atention.AutoSize = true;
            this.atention.BackColor = System.Drawing.Color.Transparent;
            this.atention.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atention.ForeColor = System.Drawing.Color.Red;
            this.atention.Location = new System.Drawing.Point(164, 375);
            this.atention.Name = "atention";
            this.atention.Size = new System.Drawing.Size(416, 29);
            this.atention.TabIndex = 5;
            this.atention.Text = "You entered wrong login or password";
            this.atention.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign in as user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::TrainManager.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atention);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label atention;
        private System.Windows.Forms.Button button1;
    }
}

