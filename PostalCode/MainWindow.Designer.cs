namespace PostalCode
{
    partial class PostalCode
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
            this.screenPanel = new System.Windows.Forms.Panel();
            this.panelKeyboard = new System.Windows.Forms.Panel();
            this.code = new System.Windows.Forms.TextBox();
            this.screenPanel.SuspendLayout();
            this.SuspendLayout();
            this.keyboard = new Keyboard();
            // 
            // screenPanel
            // 
            this.screenPanel.Controls.Add(this.code);
            this.screenPanel.Location = new System.Drawing.Point(12, 12);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(280, 228);
            this.screenPanel.TabIndex = 0;
            // 
            // panelKeyboard
            // 
            this.panelKeyboard.Location = new System.Drawing.Point(12, 246);
            this.panelKeyboard.Name = "panelKeyboard";
            this.panelKeyboard.Size = new System.Drawing.Size(280, 183);
            this.panelKeyboard.TabIndex = 1;
            this.panelKeyboard.Controls.Add(this.keyboard);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(64, 98);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(147, 20);
            this.code.TabIndex = 0;
            this.code.Enter += new System.EventHandler(this.code_Enter);
            // 
            // PostalCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.panelKeyboard);
            this.Controls.Add(this.screenPanel);
            this.Name = "PostalCode";
            this.Text = "Postal Code";
            this.screenPanel.ResumeLayout(false);
            this.screenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenPanel;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Panel panelKeyboard;
        private Keyboard keyboard;
    }
}

