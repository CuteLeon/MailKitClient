namespace MailKitClient.Forms
{
    partial class MailClientForm
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
            this.MainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.AttachmentLabel = new System.Windows.Forms.Label();
            this.AttachmentButton = new System.Windows.Forms.Button();
            this.BodyTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceiverTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.MainTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTablePanel
            // 
            this.MainTablePanel.ColumnCount = 4;
            this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MainTablePanel.Controls.Add(this.AttachmentLabel, 2, 2);
            this.MainTablePanel.Controls.Add(this.AttachmentButton, 3, 2);
            this.MainTablePanel.Controls.Add(this.BodyTextBox, 2, 3);
            this.MainTablePanel.Controls.Add(this.SubjectTextBox, 2, 1);
            this.MainTablePanel.Controls.Add(this.label4, 1, 3);
            this.MainTablePanel.Controls.Add(this.label3, 1, 2);
            this.MainTablePanel.Controls.Add(this.label2, 1, 1);
            this.MainTablePanel.Controls.Add(this.listBox1, 0, 0);
            this.MainTablePanel.Controls.Add(this.label1, 1, 0);
            this.MainTablePanel.Controls.Add(this.ReceiverTextBox, 2, 0);
            this.MainTablePanel.Controls.Add(this.SendButton, 3, 4);
            this.MainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.MainTablePanel.Name = "MainTablePanel";
            this.MainTablePanel.RowCount = 5;
            this.MainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.MainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.MainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.MainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainTablePanel.Size = new System.Drawing.Size(800, 450);
            this.MainTablePanel.TabIndex = 0;
            // 
            // AttachmentLabel
            // 
            this.AttachmentLabel.AutoEllipsis = true;
            this.AttachmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttachmentLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AttachmentLabel.Location = new System.Drawing.Point(403, 64);
            this.AttachmentLabel.Name = "AttachmentLabel";
            this.AttachmentLabel.Size = new System.Drawing.Size(314, 32);
            this.AttachmentLabel.TabIndex = 11;
            this.AttachmentLabel.Text = "附件";
            this.AttachmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AttachmentButton
            // 
            this.AttachmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttachmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachmentButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AttachmentButton.Location = new System.Drawing.Point(723, 67);
            this.AttachmentButton.Name = "AttachmentButton";
            this.AttachmentButton.Size = new System.Drawing.Size(74, 26);
            this.AttachmentButton.TabIndex = 10;
            this.AttachmentButton.Text = "附件";
            this.AttachmentButton.UseVisualStyleBackColor = true;
            this.AttachmentButton.Click += new System.EventHandler(this.AttachmentButton_Click);
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTablePanel.SetColumnSpan(this.BodyTextBox, 2);
            this.BodyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BodyTextBox.Location = new System.Drawing.Point(403, 99);
            this.BodyTextBox.Multiline = true;
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.Size = new System.Drawing.Size(394, 308);
            this.BodyTextBox.TabIndex = 8;
            this.BodyTextBox.Text = "<h1>Hi:</h1>\r\n<h3>How are u?</h3>";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTablePanel.SetColumnSpan(this.SubjectTextBox, 2);
            this.SubjectTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubjectTextBox.Location = new System.Drawing.Point(403, 35);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(394, 22);
            this.SubjectTextBox.TabIndex = 6;
            this.SubjectTextBox.Text = "Greet";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(323, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 314);
            this.label4.TabIndex = 4;
            this.label4.Text = "附件";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(323, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "附件";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(323, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "主题";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "How are u? (From: Leon.ID@QQ.COM)"});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.MainTablePanel.SetRowSpan(this.listBox1, 5);
            this.listBox1.Size = new System.Drawing.Size(314, 444);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(323, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "收件人";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReceiverTextBox
            // 
            this.ReceiverTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ReceiverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTablePanel.SetColumnSpan(this.ReceiverTextBox, 2);
            this.ReceiverTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiverTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReceiverTextBox.Location = new System.Drawing.Point(403, 3);
            this.ReceiverTextBox.Name = "ReceiverTextBox";
            this.ReceiverTextBox.Size = new System.Drawing.Size(394, 22);
            this.ReceiverTextBox.TabIndex = 5;
            this.ReceiverTextBox.Text = "Leon.ID@qq.com;SystemRC@yeah.net";
            // 
            // SendButton
            // 
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendButton.Location = new System.Drawing.Point(723, 413);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(74, 34);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MailClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTablePanel);
            this.Name = "MailClientForm";
            this.Text = "MailClientForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MailClientForm_Shown);
            this.MainTablePanel.ResumeLayout(false);
            this.MainTablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTablePanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReceiverTextBox;
        private System.Windows.Forms.TextBox BodyTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button AttachmentButton;
        private System.Windows.Forms.Label AttachmentLabel;
    }
}