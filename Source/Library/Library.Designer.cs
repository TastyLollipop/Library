
namespace Library
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.convertButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.convertButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.convertButton.Location = new System.Drawing.Point(5, 171);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(334, 30);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.browseButton.Location = new System.Drawing.Point(5, 141);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(334, 30);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathBox
            // 
            this.pathBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pathBox.Location = new System.Drawing.Point(5, 111);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(334, 20);
            this.pathBox.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(5, 65);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(334, 23);
            this.progressBar.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AllowDrop = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(5, 52);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(334, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status: Idle";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter2
            // 
            this.splitter2.CausesValidation = false;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(5, 88);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(334, 10);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.CausesValidation = false;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(5, 42);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(334, 10);
            this.splitter3.TabIndex = 7;
            this.splitter3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(5, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.CausesValidation = false;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(5, 131);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(334, 10);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "The Perfect Way Of Sorting Steam Mods";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "By Lollipop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutButton
            // 
            this.aboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutButton.Location = new System.Drawing.Point(5, 201);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(334, 30);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.aboutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Library";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.Button convertButton;
        public System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button aboutButton;
    }
}

