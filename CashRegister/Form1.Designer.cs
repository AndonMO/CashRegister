namespace CashRegister
{
    partial class CashRegisterProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashRegisterProgram));
            this.titleLabel = new System.Windows.Forms.Label();
            this.stinkLabel = new System.Windows.Forms.Label();
            this.stinkInput = new System.Windows.Forms.TextBox();
            this.levitationLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.levitationInput = new System.Windows.Forms.TextBox();
            this.speedInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.IndianRed;
            this.titleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(0, -8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(801, 53);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The General Potion Merchant";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stinkLabel
            // 
            this.stinkLabel.AutoSize = true;
            this.stinkLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stinkLabel.Location = new System.Drawing.Point(16, 95);
            this.stinkLabel.Name = "stinkLabel";
            this.stinkLabel.Size = new System.Drawing.Size(92, 15);
            this.stinkLabel.TabIndex = 1;
            this.stinkLabel.Text = "Stink Potions";
            // 
            // stinkInput
            // 
            this.stinkInput.Location = new System.Drawing.Point(148, 95);
            this.stinkInput.Name = "stinkInput";
            this.stinkInput.Size = new System.Drawing.Size(130, 20);
            this.stinkInput.TabIndex = 2;
            this.stinkInput.Text = "0";
            // 
            // levitationLabel
            // 
            this.levitationLabel.AutoSize = true;
            this.levitationLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levitationLabel.Location = new System.Drawing.Point(16, 133);
            this.levitationLabel.Name = "levitationLabel";
            this.levitationLabel.Size = new System.Drawing.Size(124, 15);
            this.levitationLabel.TabIndex = 3;
            this.levitationLabel.Text = "Levitation Potions";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(16, 172);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(100, 15);
            this.speedLabel.TabIndex = 4;
            this.speedLabel.Text = "Speed Potions";
            // 
            // levitationInput
            // 
            this.levitationInput.Location = new System.Drawing.Point(148, 131);
            this.levitationInput.Name = "levitationInput";
            this.levitationInput.Size = new System.Drawing.Size(130, 20);
            this.levitationInput.TabIndex = 5;
            this.levitationInput.Text = "0";
            // 
            // speedInput
            // 
            this.speedInput.Location = new System.Drawing.Point(148, 172);
            this.speedInput.Name = "speedInput";
            this.speedInput.Size = new System.Drawing.Size(130, 20);
            this.speedInput.TabIndex = 6;
            this.speedInput.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.calculateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(38, 198);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(210, 47);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(16, 269);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(62, 15);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(16, 297);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(30, 15);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(16, 325);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 15);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(16, 358);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(69, 15);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Tendered";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.White;
            this.subtotalOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(148, 269);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 20);
            this.subtotalOutput.TabIndex = 12;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(148, 297);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 20);
            this.taxOutput.TabIndex = 14;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(148, 325);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 20);
            this.totalOutput.TabIndex = 15;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(148, 358);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 20);
            this.tenderedInput.TabIndex = 16;
            this.tenderedInput.Text = "0";
            // 
            // changeButton
            // 
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.changeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(38, 391);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(210, 47);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.tenderedButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.White;
            this.changeOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(148, 454);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 20);
            this.changeOutput.TabIndex = 18;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(16, 459);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(57, 15);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change";
            // 
            // printButton
            // 
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.printButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(38, 484);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(210, 47);
            this.printButton.TabIndex = 20;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.receiptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(378, 65);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(374, 428);
            this.receiptLabel.TabIndex = 21;
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.newOrderButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(378, 496);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(215, 35);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(636, 496);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 35);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CashRegisterProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::CashRegister.Properties.Resources.CashBackground;
            this.ClientSize = new System.Drawing.Size(786, 543);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.speedInput);
            this.Controls.Add(this.levitationInput);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.levitationLabel);
            this.Controls.Add(this.stinkInput);
            this.Controls.Add(this.stinkLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashRegisterProgram";
            this.Text = "CashRegisterProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label stinkLabel;
        private System.Windows.Forms.TextBox stinkInput;
        private System.Windows.Forms.Label levitationLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox levitationInput;
        private System.Windows.Forms.TextBox speedInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button exitButton;
    }
}

