namespace WindowsFormsApplication1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.runnerTextbox = new System.Windows.Forms.TextBox();
            this.gameTextBox = new System.Windows.Forms.TextBox();
            this.estTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scheduleLocationTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.categoryTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.comms1TextBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.comms1Label = new System.Windows.Forms.Label();
            this.comms2TextBox = new System.Windows.Forms.TextBox();
            this.comms2Label = new System.Windows.Forms.Label();
            this.runnerPronounsTextBox = new System.Windows.Forms.TextBox();
            this.hostPronounsTextBox = new System.Windows.Forms.TextBox();
            this.comms1PronounsTextBox = new System.Windows.Forms.TextBox();
            this.comms2PronounsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runnerTextbox
            // 
            this.runnerTextbox.Location = new System.Drawing.Point(92, 12);
            this.runnerTextbox.Name = "runnerTextbox";
            this.runnerTextbox.Size = new System.Drawing.Size(95, 20);
            this.runnerTextbox.TabIndex = 0;
            // 
            // gameTextBox
            // 
            this.gameTextBox.Location = new System.Drawing.Point(92, 38);
            this.gameTextBox.Name = "gameTextBox";
            this.gameTextBox.Size = new System.Drawing.Size(156, 20);
            this.gameTextBox.TabIndex = 1;
            // 
            // estTextbox
            // 
            this.estTextbox.Location = new System.Drawing.Point(92, 64);
            this.estTextbox.Name = "estTextbox";
            this.estTextbox.Size = new System.Drawing.Size(156, 20);
            this.estTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Runner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estimate";
            // 
            // scheduleLocationTextbox
            // 
            this.scheduleLocationTextbox.Location = new System.Drawing.Point(73, 197);
            this.scheduleLocationTextbox.Name = "scheduleLocationTextbox";
            this.scheduleLocationTextbox.ReadOnly = true;
            this.scheduleLocationTextbox.Size = new System.Drawing.Size(145, 20);
            this.scheduleLocationTextbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Schedule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(12, 229);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(236, 23);
            this.updateInfoButton.TabIndex = 9;
            this.updateInfoButton.Text = "Update Information";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(12, 265);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 10;
            this.prevButton.Text = "<- Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(173, 265);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next ->";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // categoryTextbox
            // 
            this.categoryTextbox.Location = new System.Drawing.Point(92, 90);
            this.categoryTextbox.Name = "categoryTextbox";
            this.categoryTextbox.Size = new System.Drawing.Size(156, 20);
            this.categoryTextbox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Category";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(92, 116);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(95, 20);
            this.hostTextBox.TabIndex = 1;
            // 
            // comms1TextBox
            // 
            this.comms1TextBox.Location = new System.Drawing.Point(92, 142);
            this.comms1TextBox.Name = "comms1TextBox";
            this.comms1TextBox.Size = new System.Drawing.Size(95, 20);
            this.comms1TextBox.TabIndex = 2;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(12, 119);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(29, 13);
            this.hostLabel.TabIndex = 4;
            this.hostLabel.Text = "Host";
            // 
            // comms1Label
            // 
            this.comms1Label.AutoSize = true;
            this.comms1Label.Location = new System.Drawing.Point(12, 145);
            this.comms1Label.Name = "comms1Label";
            this.comms1Label.Size = new System.Drawing.Size(78, 13);
            this.comms1Label.TabIndex = 5;
            this.comms1Label.Text = "Commentator 1";
            // 
            // comms2TextBox
            // 
            this.comms2TextBox.Location = new System.Drawing.Point(92, 168);
            this.comms2TextBox.Name = "comms2TextBox";
            this.comms2TextBox.Size = new System.Drawing.Size(95, 20);
            this.comms2TextBox.TabIndex = 12;
            // 
            // comms2Label
            // 
            this.comms2Label.AutoSize = true;
            this.comms2Label.Location = new System.Drawing.Point(12, 171);
            this.comms2Label.Name = "comms2Label";
            this.comms2Label.Size = new System.Drawing.Size(78, 13);
            this.comms2Label.TabIndex = 13;
            this.comms2Label.Text = "Commentator 2";
            // 
            // runnerPronounsTextBox
            // 
            this.runnerPronounsTextBox.Location = new System.Drawing.Point(193, 12);
            this.runnerPronounsTextBox.Name = "runnerPronounsTextBox";
            this.runnerPronounsTextBox.Size = new System.Drawing.Size(55, 20);
            this.runnerPronounsTextBox.TabIndex = 0;
            // 
            // hostPronounsTextBox
            // 
            this.hostPronounsTextBox.Location = new System.Drawing.Point(193, 116);
            this.hostPronounsTextBox.Name = "hostPronounsTextBox";
            this.hostPronounsTextBox.Size = new System.Drawing.Size(55, 20);
            this.hostPronounsTextBox.TabIndex = 0;
            // 
            // comms1PronounsTextBox
            // 
            this.comms1PronounsTextBox.Location = new System.Drawing.Point(193, 142);
            this.comms1PronounsTextBox.Name = "comms1PronounsTextBox";
            this.comms1PronounsTextBox.Size = new System.Drawing.Size(55, 20);
            this.comms1PronounsTextBox.TabIndex = 2;
            // 
            // comms2PronounsTextBox
            // 
            this.comms2PronounsTextBox.Location = new System.Drawing.Point(193, 168);
            this.comms2PronounsTextBox.Name = "comms2PronounsTextBox";
            this.comms2PronounsTextBox.Size = new System.Drawing.Size(55, 20);
            this.comms2PronounsTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "<- Pronouns";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "<- Pronouns";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "<- Pronouns";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "<- Pronouns";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 303);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comms2Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comms2PronounsTextBox);
            this.Controls.Add(this.comms2TextBox);
            this.Controls.Add(this.categoryTextbox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.updateInfoButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comms1Label);
            this.Controls.Add(this.scheduleLocationTextbox);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comms1PronounsTextBox);
            this.Controls.Add(this.comms1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.estTextbox);
            this.Controls.Add(this.gameTextBox);
            this.Controls.Add(this.hostPronounsTextBox);
            this.Controls.Add(this.runnerPronounsTextBox);
            this.Controls.Add(this.runnerTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "MarathonScreenUpdater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox runnerTextbox;
        private System.Windows.Forms.TextBox gameTextBox;
        private System.Windows.Forms.TextBox estTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scheduleLocationTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox categoryTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox comms1TextBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label comms1Label;
        private System.Windows.Forms.TextBox comms2TextBox;
        private System.Windows.Forms.Label comms2Label;
        private System.Windows.Forms.TextBox runnerPronounsTextBox;
        private System.Windows.Forms.TextBox hostPronounsTextBox;
        private System.Windows.Forms.TextBox comms1PronounsTextBox;
        private System.Windows.Forms.TextBox comms2PronounsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

