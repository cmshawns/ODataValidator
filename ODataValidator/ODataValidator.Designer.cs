namespace ODataValidator
{
    partial class ODataValidator
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
            this.MetadataText = new System.Windows.Forms.RichTextBox();
            this.Validate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MetadataText
            // 
            this.MetadataText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetadataText.Location = new System.Drawing.Point(12, 12);
            this.MetadataText.Name = "MetadataText";
            this.MetadataText.Size = new System.Drawing.Size(443, 398);
            this.MetadataText.TabIndex = 0;
            this.MetadataText.Text = "";
            this.MetadataText.TextChanged += new System.EventHandler(this.MetadataText_TextChanged);
            // 
            // Validate
            // 
            this.Validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Validate.Location = new System.Drawing.Point(353, 419);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(102, 23);
            this.Validate.TabIndex = 1;
            this.Validate.Text = "Validate!";
            this.Validate.UseVisualStyleBackColor = true;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // ODataValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 454);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.MetadataText);
            this.Name = "ODataValidator";
            this.Text = "ODataValidator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MetadataText;
        private System.Windows.Forms.Button Validate;
    }
}