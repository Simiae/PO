
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
            this.pracovniEmailLabel = new System.Windows.Forms.Label();
            this.pracovniEmailTextBox = new System.Windows.Forms.TextBox();
            this.soukromyEmailLabel = new System.Windows.Forms.Label();
            this.soukromyEmailTextBox = new System.Windows.Forms.TextBox();
            this.doktorandCheckBox = new System.Windows.Forms.CheckBox();
            this.uvazekLabel = new System.Windows.Forms.Label();
            this.uvazekTextBox = new System.Windows.Forms.TextBox();
            this.pracovniTelefonLabel = new System.Windows.Forms.Label();
            this.pracovniTelefonTextBox = new System.Windows.Forms.TextBox();
            this.soukromyTelefonLabel = new System.Windows.Forms.Label();
            this.soukromyTelefonTextBox = new System.Windows.Forms.TextBox();
            this.zamestnanciListBox = new System.Windows.Forms.ListBox();
            this.odebratZamestnanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Location = new System.Drawing.Point(69, 50);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(54, 17);
            this.jmenoLabel.TabIndex = 0;
            this.jmenoLabel.Text = "Jméno:";
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
            this.prijmeniLabel.Text = "Příjmení:";
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
            this.pridejZamestnanceButton.Location = new System.Drawing.Point(137, 381);
            this.pridejZamestnanceButton.Name = "pridejZamestnanceButton";
            this.pridejZamestnanceButton.Size = new System.Drawing.Size(141, 36);
            this.pridejZamestnanceButton.TabIndex = 2;
            this.pridejZamestnanceButton.Text = "Přidej zaměstnance";
            this.pridejZamestnanceButton.UseVisualStyleBackColor = true;
            this.pridejZamestnanceButton.Click += new System.EventHandler(this.pridejZamestnanceButton_Click);
            // 
            // pracovniEmailLabel
            // 
            this.pracovniEmailLabel.AutoSize = true;
            this.pracovniEmailLabel.Location = new System.Drawing.Point(69, 128);
            this.pracovniEmailLabel.Name = "pracovniEmailLabel";
            this.pracovniEmailLabel.Size = new System.Drawing.Size(104, 17);
            this.pracovniEmailLabel.TabIndex = 3;
            this.pracovniEmailLabel.Text = "Pracovní email:";
            // 
            // pracovniEmailTextBox
            // 
            this.pracovniEmailTextBox.Location = new System.Drawing.Point(197, 123);
            this.pracovniEmailTextBox.Name = "pracovniEmailTextBox";
            this.pracovniEmailTextBox.Size = new System.Drawing.Size(141, 22);
            this.pracovniEmailTextBox.TabIndex = 4;
            // 
            // soukromyEmailLabel
            // 
            this.soukromyEmailLabel.AutoSize = true;
            this.soukromyEmailLabel.Location = new System.Drawing.Point(69, 168);
            this.soukromyEmailLabel.Name = "soukromyEmailLabel";
            this.soukromyEmailLabel.Size = new System.Drawing.Size(112, 17);
            this.soukromyEmailLabel.TabIndex = 3;
            this.soukromyEmailLabel.Text = "Soukromý email:";
            // 
            // soukromyEmailTextBox
            // 
            this.soukromyEmailTextBox.Location = new System.Drawing.Point(197, 165);
            this.soukromyEmailTextBox.Name = "soukromyEmailTextBox";
            this.soukromyEmailTextBox.Size = new System.Drawing.Size(141, 22);
            this.soukromyEmailTextBox.TabIndex = 4;
            // 
            // doktorandCheckBox
            // 
            this.doktorandCheckBox.AutoSize = true;
            this.doktorandCheckBox.Location = new System.Drawing.Point(72, 206);
            this.doktorandCheckBox.Name = "doktorandCheckBox";
            this.doktorandCheckBox.Size = new System.Drawing.Size(96, 21);
            this.doktorandCheckBox.TabIndex = 5;
            this.doktorandCheckBox.Text = "Doktorand";
            this.doktorandCheckBox.UseVisualStyleBackColor = true;
            // 
            // uvazekLabel
            // 
            this.uvazekLabel.AutoSize = true;
            this.uvazekLabel.Location = new System.Drawing.Point(69, 250);
            this.uvazekLabel.Name = "uvazekLabel";
            this.uvazekLabel.Size = new System.Drawing.Size(59, 17);
            this.uvazekLabel.TabIndex = 3;
            this.uvazekLabel.Text = "Úvazek:";
            // 
            // uvazekTextBox
            // 
            this.uvazekTextBox.Location = new System.Drawing.Point(137, 247);
            this.uvazekTextBox.Name = "uvazekTextBox";
            this.uvazekTextBox.Size = new System.Drawing.Size(141, 22);
            this.uvazekTextBox.TabIndex = 4;
            // 
            // pracovniTelefonLabel
            // 
            this.pracovniTelefonLabel.AutoSize = true;
            this.pracovniTelefonLabel.Location = new System.Drawing.Point(69, 297);
            this.pracovniTelefonLabel.Name = "pracovniTelefonLabel";
            this.pracovniTelefonLabel.Size = new System.Drawing.Size(114, 17);
            this.pracovniTelefonLabel.TabIndex = 3;
            this.pracovniTelefonLabel.Text = "Pracovní telefon:";
            // 
            // pracovniTelefonTextBox
            // 
            this.pracovniTelefonTextBox.Location = new System.Drawing.Point(197, 292);
            this.pracovniTelefonTextBox.Name = "pracovniTelefonTextBox";
            this.pracovniTelefonTextBox.Size = new System.Drawing.Size(141, 22);
            this.pracovniTelefonTextBox.TabIndex = 4;
            // 
            // soukromyTelefonLabel
            // 
            this.soukromyTelefonLabel.AutoSize = true;
            this.soukromyTelefonLabel.Location = new System.Drawing.Point(69, 337);
            this.soukromyTelefonLabel.Name = "soukromyTelefonLabel";
            this.soukromyTelefonLabel.Size = new System.Drawing.Size(122, 17);
            this.soukromyTelefonLabel.TabIndex = 3;
            this.soukromyTelefonLabel.Text = "Soukromý telefon:";
            // 
            // soukromyTelefonTextBox
            // 
            this.soukromyTelefonTextBox.Location = new System.Drawing.Point(197, 332);
            this.soukromyTelefonTextBox.Name = "soukromyTelefonTextBox";
            this.soukromyTelefonTextBox.Size = new System.Drawing.Size(141, 22);
            this.soukromyTelefonTextBox.TabIndex = 4;
            // 
            // zamestnanciListBox
            // 
            this.zamestnanciListBox.FormattingEnabled = true;
            this.zamestnanciListBox.ItemHeight = 16;
            this.zamestnanciListBox.Location = new System.Drawing.Point(390, 47);
            this.zamestnanciListBox.Name = "zamestnanciListBox";
            this.zamestnanciListBox.Size = new System.Drawing.Size(233, 340);
            this.zamestnanciListBox.TabIndex = 6;
            // 
            // odebratZamestnanceButton
            // 
            this.odebratZamestnanceButton.Location = new System.Drawing.Point(647, 195);
            this.odebratZamestnanceButton.Name = "odebratZamestnanceButton";
            this.odebratZamestnanceButton.Size = new System.Drawing.Size(114, 51);
            this.odebratZamestnanceButton.TabIndex = 7;
            this.odebratZamestnanceButton.Text = "Odebrat zaměstnance";
            this.odebratZamestnanceButton.UseVisualStyleBackColor = true;
            // 
            // VytvorZamestnanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odebratZamestnanceButton);
            this.Controls.Add(this.zamestnanciListBox);
            this.Controls.Add(this.doktorandCheckBox);
            this.Controls.Add(this.uvazekTextBox);
            this.Controls.Add(this.soukromyTelefonTextBox);
            this.Controls.Add(this.soukromyEmailTextBox);
            this.Controls.Add(this.uvazekLabel);
            this.Controls.Add(this.soukromyTelefonLabel);
            this.Controls.Add(this.soukromyEmailLabel);
            this.Controls.Add(this.pracovniTelefonTextBox);
            this.Controls.Add(this.pracovniEmailTextBox);
            this.Controls.Add(this.pracovniTelefonLabel);
            this.Controls.Add(this.pracovniEmailLabel);
            this.Controls.Add(this.pridejZamestnanceButton);
            this.Controls.Add(this.prijmeniTextBox);
            this.Controls.Add(this.prijmeniLabel);
            this.Controls.Add(this.jmenoTextBox);
            this.Controls.Add(this.jmenoLabel);
            this.Name = "VytvorZamestnanceForm";
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
        private System.Windows.Forms.Label pracovniEmailLabel;
        private System.Windows.Forms.TextBox pracovniEmailTextBox;
        private System.Windows.Forms.Label soukromyEmailLabel;
        private System.Windows.Forms.TextBox soukromyEmailTextBox;
        private System.Windows.Forms.CheckBox doktorandCheckBox;
        private System.Windows.Forms.Label uvazekLabel;
        private System.Windows.Forms.TextBox uvazekTextBox;
        private System.Windows.Forms.Label pracovniTelefonLabel;
        private System.Windows.Forms.TextBox pracovniTelefonTextBox;
        private System.Windows.Forms.Label soukromyTelefonLabel;
        private System.Windows.Forms.TextBox soukromyTelefonTextBox;
        private System.Windows.Forms.ListBox zamestnanciListBox;
        private System.Windows.Forms.Button odebratZamestnanceButton;
    }
}

