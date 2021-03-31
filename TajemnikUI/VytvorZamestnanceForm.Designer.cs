
namespace TajemnikUI
{
    partial class VytvorZamestnanceForm
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
            this.jmenoLabel = new System.Windows.Forms.Label();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.prijmeniLabel = new System.Windows.Forms.Label();
            this.prijmeniTextBox = new System.Windows.Forms.TextBox();
            this.pridejZamestnanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Location = new System.Drawing.Point(69, 50);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(54, 17);
            this.jmenoLabel.TabIndex = 0;
            this.jmenoLabel.Text = "Jmeno:";
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(137, 47);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(141, 22);
            this.jmenoTextBox.TabIndex = 1;
            // 
            // prijmeniLabel
            // 
            this.prijmeniLabel.AutoSize = true;
            this.prijmeniLabel.Location = new System.Drawing.Point(69, 88);
            this.prijmeniLabel.Name = "prijmeniLabel";
            this.prijmeniLabel.Size = new System.Drawing.Size(62, 17);
            this.prijmeniLabel.TabIndex = 0;
            this.prijmeniLabel.Text = "Prijmeni:";
            // 
            // prijmeniTextBox
            // 
            this.prijmeniTextBox.Location = new System.Drawing.Point(137, 85);
            this.prijmeniTextBox.Name = "prijmeniTextBox";
            this.prijmeniTextBox.Size = new System.Drawing.Size(141, 22);
            this.prijmeniTextBox.TabIndex = 1;
            // 
            // pridejZamestnanceButton
            // 
            this.pridejZamestnanceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.pridejZamestnanceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pridejZamestnanceButton.Location = new System.Drawing.Point(137, 141);
            this.pridejZamestnanceButton.Name = "pridejZamestnanceButton";
            this.pridejZamestnanceButton.Size = new System.Drawing.Size(141, 36);
            this.pridejZamestnanceButton.TabIndex = 2;
            this.pridejZamestnanceButton.Text = "Přidej zaměstnance";
            this.pridejZamestnanceButton.UseVisualStyleBackColor = true;
            this.pridejZamestnanceButton.Click += new System.EventHandler(this.pridejZamestnanceButton_Click);
            // 
            // VytvorZamestnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pridejZamestnanceButton);
            this.Controls.Add(this.prijmeniTextBox);
            this.Controls.Add(this.prijmeniLabel);
            this.Controls.Add(this.jmenoTextBox);
            this.Controls.Add(this.jmenoLabel);
            this.Name = "VytvorZamestnance";
            this.Text = "Zamestnanec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jmenoLabel;
        private System.Windows.Forms.TextBox jmenoTextBox;
        private System.Windows.Forms.Label prijmeniLabel;
        private System.Windows.Forms.TextBox prijmeniTextBox;
        private System.Windows.Forms.Button pridejZamestnanceButton;
    }
}

