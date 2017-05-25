namespace TCP_Serwer
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
            this.Adress = new System.Windows.Forms.TextBox();
            this.info_feed = new System.Windows.Forms.ListBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.stopbutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(53, 38);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(268, 20);
            this.Adress.TabIndex = 0;
            this.Adress.Text = "Adress";
            // 
            // info_feed
            // 
            this.info_feed.FormattingEnabled = true;
            this.info_feed.Location = new System.Drawing.Point(53, 91);
            this.info_feed.Name = "info_feed";
            this.info_feed.Size = new System.Drawing.Size(616, 290);
            this.info_feed.TabIndex = 1;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(422, 39);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(247, 20);
            this.port.TabIndex = 2;
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(422, 401);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 3;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(246, 401);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 4;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 447);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.port);
            this.Controls.Add(this.info_feed);
            this.Controls.Add(this.Adress);
            this.Name = "Form1";
            this.Text = "Serwer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.ListBox info_feed;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button startbutton;
    }
}

