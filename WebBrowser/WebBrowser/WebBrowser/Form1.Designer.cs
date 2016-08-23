namespace WebBrowser
{
    partial class webBrowser
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stop = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.surf = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(977, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(190, 0);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(44, 23);
            this.stop.TabIndex = 4;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(126, 0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(58, 23);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(63, 0);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(57, 23);
            this.forward.TabIndex = 2;
            this.forward.Text = "Forward";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.button2_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(45, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(289, 5);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(32, 13);
            this.urlLabel.TabIndex = 5;
            this.urlLabel.Text = "URL:";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(327, 2);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(368, 20);
            this.url.TabIndex = 6;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(701, 0);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(59, 23);
            this.go.TabIndex = 7;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(239, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(44, 23);
            this.home.TabIndex = 8;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // surf
            // 
            this.surf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surf.Location = new System.Drawing.Point(0, 25);
            this.surf.MinimumSize = new System.Drawing.Size(20, 20);
            this.surf.Name = "surf";
            this.surf.Size = new System.Drawing.Size(977, 595);
            this.surf.TabIndex = 9;
            this.surf.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.surf_DocumentCompleted);
            // 
            // webBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 620);
            this.Controls.Add(this.surf);
            this.Controls.Add(this.home);
            this.Controls.Add(this.go);
            this.Controls.Add(this.url);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.toolStrip1);
            this.Name = "webBrowser";
            this.Text = "WebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.WebBrowser surf;
    }
}

