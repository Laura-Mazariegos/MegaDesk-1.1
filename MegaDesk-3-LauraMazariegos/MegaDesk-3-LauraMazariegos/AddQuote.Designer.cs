namespace MegaDesk_3_LauraMazariegos
{
    partial class AddQuote
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
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.Label();
            this.expressLabel = new System.Windows.Forms.Label();
            this.materialsLabel = new System.Windows.Forms.Label();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.drawersComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.expressComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addQuoteButton.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteButton.Location = new System.Drawing.Point(189, 353);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(200, 50);
            this.addQuoteButton.TabIndex = 7;
            this.addQuoteButton.Text = "Add Quote";
            this.addQuoteButton.UseVisualStyleBackColor = false;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelQuoteButton.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteButton.Location = new System.Drawing.Point(432, 353);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(200, 50);
            this.cancelQuoteButton.TabIndex = 8;
            this.cancelQuoteButton.Text = "Cancel Quote";
            this.cancelQuoteButton.UseVisualStyleBackColor = false;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Express Days: 3, 5, 7, or 0 for none";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialInput
            // 
            this.materialInput.BackColor = System.Drawing.SystemColors.Info;
            this.materialInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materialInput.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialInput.Location = new System.Drawing.Point(432, 225);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(337, 34);
            this.materialInput.TabIndex = 0;
            this.materialInput.Text = "Enter material : Oak($200), Veneer($125), Laminate($100), Pine($50), Rosewood($30" +
    "0)";
            this.materialInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawersInput
            // 
            this.drawersInput.BackColor = System.Drawing.SystemColors.Info;
            this.drawersInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawersInput.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersInput.Location = new System.Drawing.Point(432, 164);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(337, 34);
            this.drawersInput.TabIndex = 0;
            this.drawersInput.Text = "Enter number of Drawers";
            this.drawersInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expressLabel
            // 
            this.expressLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expressLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.expressLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressLabel.Location = new System.Drawing.Point(56, 286);
            this.expressLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.expressLabel.Name = "expressLabel";
            this.expressLabel.Size = new System.Drawing.Size(333, 55);
            this.expressLabel.TabIndex = 18;
            this.expressLabel.Text = "Express";
            this.expressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialsLabel
            // 
            this.materialsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materialsLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialsLabel.Location = new System.Drawing.Point(56, 226);
            this.materialsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.materialsLabel.Name = "materialsLabel";
            this.materialsLabel.Size = new System.Drawing.Size(333, 57);
            this.materialsLabel.TabIndex = 17;
            this.materialsLabel.Text = "Material";
            this.materialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawersLabel
            // 
            this.drawersLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.drawersLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawersLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersLabel.Location = new System.Drawing.Point(56, 165);
            this.drawersLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(333, 57);
            this.drawersLabel.TabIndex = 16;
            this.drawersLabel.Text = "# of Drawers";
            this.drawersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthLabel
            // 
            this.widthLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.widthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.widthLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(56, 69);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(333, 38);
            this.widthLabel.TabIndex = 15;
            this.widthLabel.Text = "Desk Width";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightLabel
            // 
            this.heightLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.heightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heightLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(56, 116);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(333, 34);
            this.heightLabel.TabIndex = 14;
            this.heightLabel.Text = "Desk Height";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawersComboBox
            // 
            this.drawersComboBox.FormattingEnabled = true;
            this.drawersComboBox.Location = new System.Drawing.Point(432, 201);
            this.drawersComboBox.Name = "drawersComboBox";
            this.drawersComboBox.Size = new System.Drawing.Size(337, 21);
            this.drawersComboBox.TabIndex = 4;
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(432, 262);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(337, 21);
            this.materialComboBox.TabIndex = 5;
            // 
            // expressComboBox
            // 
            this.expressComboBox.FormattingEnabled = true;
            this.expressComboBox.Location = new System.Drawing.Point(432, 320);
            this.expressComboBox.Name = "expressComboBox";
            this.expressComboBox.Size = new System.Drawing.Size(337, 21);
            this.expressComboBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(56, 27);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(333, 36);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Customer Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(432, 33);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(337, 30);
            this.nameInput.TabIndex = 1;
            this.nameInput.Text = "Enter Customer Name";
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.Location = new System.Drawing.Point(432, 77);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(337, 30);
            this.widthInput.TabIndex = 2;
            this.widthInput.Text = "Enter Desk Width";
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthInput.TextChanged += new System.EventHandler(this.widthInput_TextChanged);
            // 
            // heightInput
            // 
            this.heightInput.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightInput.Location = new System.Drawing.Point(432, 120);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(337, 30);
            this.heightInput.TabIndex = 3;
            this.heightInput.Text = "Enter Desk Height";
            this.heightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightInput.TextChanged += new System.EventHandler(this.heightInput_TextChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.expressComboBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.drawersComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.expressLabel);
            this.Controls.Add(this.materialsLabel);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.cancelQuoteButton);
            this.Controls.Add(this.addQuoteButton);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label materialInput;
        private System.Windows.Forms.Label drawersInput;
        private System.Windows.Forms.Label expressLabel;
        private System.Windows.Forms.Label materialsLabel;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.ComboBox drawersComboBox;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.ComboBox expressComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox heightInput;
    }
}