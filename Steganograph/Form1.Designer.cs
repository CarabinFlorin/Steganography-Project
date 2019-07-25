namespace Steganograph
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
            this.ButtonChoseEmbed = new System.Windows.Forms.Button();
            this.ButtonEmbed = new System.Windows.Forms.Button();
            this.ButtonChoseRead = new System.Windows.Forms.Button();
            this.textEmbed = new System.Windows.Forms.RichTextBox();
            this.textRead = new System.Windows.Forms.RichTextBox();
            this.Embed = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEmbed = new System.Windows.Forms.PictureBox();
            this.pictureRead = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Embed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmbed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRead)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonChoseEmbed
            // 
            this.ButtonChoseEmbed.Location = new System.Drawing.Point(159, 343);
            this.ButtonChoseEmbed.Name = "ButtonChoseEmbed";
            this.ButtonChoseEmbed.Size = new System.Drawing.Size(132, 36);
            this.ButtonChoseEmbed.TabIndex = 0;
            this.ButtonChoseEmbed.Text = "Choose picture";
            this.ButtonChoseEmbed.UseVisualStyleBackColor = true;
            this.ButtonChoseEmbed.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonEmbed
            // 
            this.ButtonEmbed.Enabled = false;
            this.ButtonEmbed.Location = new System.Drawing.Point(159, 535);
            this.ButtonEmbed.Name = "ButtonEmbed";
            this.ButtonEmbed.Size = new System.Drawing.Size(132, 36);
            this.ButtonEmbed.TabIndex = 3;
            this.ButtonEmbed.Text = "Embed and Save";
            this.ButtonEmbed.UseVisualStyleBackColor = true;
            this.ButtonEmbed.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ButtonChoseRead
            // 
            this.ButtonChoseRead.Location = new System.Drawing.Point(165, 343);
            this.ButtonChoseRead.Name = "ButtonChoseRead";
            this.ButtonChoseRead.Size = new System.Drawing.Size(132, 36);
            this.ButtonChoseRead.TabIndex = 5;
            this.ButtonChoseRead.Text = "Choose picture";
            this.ButtonChoseRead.UseVisualStyleBackColor = true;
            this.ButtonChoseRead.Click += new System.EventHandler(this.ButtonChoseRead_Click);
            // 
            // textEmbed
            // 
            this.textEmbed.Enabled = false;
            this.textEmbed.Location = new System.Drawing.Point(6, 415);
            this.textEmbed.Name = "textEmbed";
            this.textEmbed.Size = new System.Drawing.Size(451, 114);
            this.textEmbed.TabIndex = 8;
            this.textEmbed.Text = "Choose a picture first";
            // 
            // textRead
            // 
            this.textRead.Location = new System.Drawing.Point(6, 415);
            this.textRead.Name = "textRead";
            this.textRead.ReadOnly = true;
            this.textRead.Size = new System.Drawing.Size(451, 114);
            this.textRead.TabIndex = 9;
            this.textRead.Text = "Choose a picture first";
            // 
            // Embed
            // 
            this.Embed.Controls.Add(this.label1);
            this.Embed.Controls.Add(this.textEmbed);
            this.Embed.Controls.Add(this.ButtonEmbed);
            this.Embed.Controls.Add(this.pictureEmbed);
            this.Embed.Controls.Add(this.ButtonChoseEmbed);
            this.Embed.Location = new System.Drawing.Point(12, 12);
            this.Embed.Name = "Embed";
            this.Embed.Size = new System.Drawing.Size(463, 581);
            this.Embed.TabIndex = 10;
            this.Embed.TabStop = false;
            this.Embed.Text = "Embed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Write message here";
            // 
            // pictureEmbed
            // 
            this.pictureEmbed.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.pictureEmbed.Image = global::Steganograph.Properties.Resources.image_placeholder_png_698412;
            this.pictureEmbed.Location = new System.Drawing.Point(6, 21);
            this.pictureEmbed.Name = "pictureEmbed";
            this.pictureEmbed.Size = new System.Drawing.Size(451, 299);
            this.pictureEmbed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEmbed.TabIndex = 1;
            this.pictureEmbed.TabStop = false;
            // 
            // pictureRead
            // 
            this.pictureRead.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.pictureRead.Image = global::Steganograph.Properties.Resources.image_placeholder_png_698412;
            this.pictureRead.Location = new System.Drawing.Point(6, 21);
            this.pictureRead.Name = "pictureRead";
            this.pictureRead.Size = new System.Drawing.Size(451, 299);
            this.pictureRead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRead.TabIndex = 4;
            this.pictureRead.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureRead);
            this.groupBox1.Controls.Add(this.ButtonChoseRead);
            this.groupBox1.Controls.Add(this.textRead);
            this.groupBox1.Location = new System.Drawing.Point(492, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 581);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Decoded message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Embed);
            this.Name = "Form1";
            this.Text = "Sternograph";
            this.Embed.ResumeLayout(false);
            this.Embed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmbed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRead)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonChoseEmbed;
        private System.Windows.Forms.PictureBox pictureEmbed;
        private System.Windows.Forms.Button ButtonEmbed;
        private System.Windows.Forms.PictureBox pictureRead;
        private System.Windows.Forms.Button ButtonChoseRead;
        private System.Windows.Forms.RichTextBox textEmbed;
        private System.Windows.Forms.RichTextBox textRead;
        private System.Windows.Forms.GroupBox Embed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

