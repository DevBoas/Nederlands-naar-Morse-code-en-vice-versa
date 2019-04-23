namespace Nederlands_naar_Morse_code_en_vice_versa
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
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonToMorse = new System.Windows.Forms.Button();
            this.ButtonToNL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(77, 37);
            this.TextBoxInput.Multiline = true;
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(328, 103);
            this.TextBoxInput.TabIndex = 0;
            // 
            // ButtonToMorse
            // 
            this.ButtonToMorse.Location = new System.Drawing.Point(77, 158);
            this.ButtonToMorse.Name = "ButtonToMorse";
            this.ButtonToMorse.Size = new System.Drawing.Size(75, 23);
            this.ButtonToMorse.TabIndex = 1;
            this.ButtonToMorse.Text = "Morse";
            this.ButtonToMorse.UseVisualStyleBackColor = true;
            this.ButtonToMorse.Click += new System.EventHandler(this.ButtonToMorse_Click);
            // 
            // ButtonToNL
            // 
            this.ButtonToNL.Location = new System.Drawing.Point(330, 158);
            this.ButtonToNL.Name = "ButtonToNL";
            this.ButtonToNL.Size = new System.Drawing.Size(75, 23);
            this.ButtonToNL.TabIndex = 2;
            this.ButtonToNL.Text = "NL";
            this.ButtonToNL.UseVisualStyleBackColor = true;
            this.ButtonToNL.Click += new System.EventHandler(this.ButtonToNL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ButtonToNL);
            this.Controls.Add(this.ButtonToMorse);
            this.Controls.Add(this.TextBoxInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Nederlands naar Morse code en vice versa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonToMorse;
        private System.Windows.Forms.Button ButtonToNL;
    }
}

