/*Zachary Hodgson
 * ITSE 1430
 * Mr. Taylor
 * Lab 3
 * 4/21/2020
 */

namespace CharacterCreator.Winforms
{
    partial class CharacterCreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxProfession = new System.Windows.Forms.ComboBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.txtPointsRemaining = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPlusStr = new System.Windows.Forms.Button();
            this.btnMinStr = new System.Windows.Forms.Button();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.txtAgility = new System.Windows.Forms.TextBox();
            this.txtConstitution = new System.Windows.Forms.TextBox();
            this.txtCharisma = new System.Windows.Forms.TextBox();
            this.btnPlusInt = new System.Windows.Forms.Button();
            this.btnPlusAgi = new System.Windows.Forms.Button();
            this.btnPlusCon = new System.Windows.Forms.Button();
            this.btnPlusCha = new System.Windows.Forms.Button();
            this.btnMinInt = new System.Windows.Forms.Button();
            this.btnMinAgi = new System.Windows.Forms.Button();
            this.btnMinCon = new System.Windows.Forms.Button();
            this.btnMinCha = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(87, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(175, 447);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 447);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(11, 248);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(57, 13);
            this.lblPoints.TabIndex = 23;
            this.lblPoints.Text = "Points Left";
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Location = new System.Drawing.Point(11, 39);
            this.lblProfession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(56, 13);
            this.lblProfession.TabIndex = 30;
            this.lblProfession.Text = "Profession";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(11, 69);
            this.lblRace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 29;
            this.lblRace.Text = "Race";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Strength";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Intelligence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Constitution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Agility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Charisma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Description";
            // 
            // richTextDescription
            // 
            this.richTextDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextDescription.Location = new System.Drawing.Point(14, 301);
            this.richTextDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(279, 142);
            this.richTextDescription.TabIndex = 19;
            this.richTextDescription.Text = "";
            // 
            // comboBoxProfession
            // 
            this.comboBoxProfession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfession.FormattingEnabled = true;
            this.comboBoxProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.comboBoxProfession.Location = new System.Drawing.Point(87, 36);
            this.comboBoxProfession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProfession.Name = "comboBoxProfession";
            this.comboBoxProfession.Size = new System.Drawing.Size(135, 21);
            this.comboBoxProfession.Sorted = true;
            this.comboBoxProfession.TabIndex = 1;
            this.comboBoxProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateProfession);
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.comboBoxRace.Location = new System.Drawing.Point(87, 66);
            this.comboBoxRace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(135, 21);
            this.comboBoxRace.Sorted = true;
            this.comboBoxRace.TabIndex = 2;
            this.comboBoxRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateRace);
            // 
            // txtPointsRemaining
            // 
            this.txtPointsRemaining.Location = new System.Drawing.Point(121, 245);
            this.txtPointsRemaining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPointsRemaining.Name = "txtPointsRemaining";
            this.txtPointsRemaining.ReadOnly = true;
            this.txtPointsRemaining.Size = new System.Drawing.Size(41, 20);
            this.txtPointsRemaining.TabIndex = 18;
            this.txtPointsRemaining.Text = "50";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name";
            // 
            // btnPlusStr
            // 
            this.btnPlusStr.Location = new System.Drawing.Point(141, 99);
            this.btnPlusStr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusStr.Name = "btnPlusStr";
            this.btnPlusStr.Size = new System.Drawing.Size(21, 18);
            this.btnPlusStr.TabIndex = 4;
            this.btnPlusStr.Text = "+";
            this.btnPlusStr.UseVisualStyleBackColor = true;
            this.btnPlusStr.Click += new System.EventHandler(this.AddStrength);
            // 
            // btnMinStr
            // 
            this.btnMinStr.Location = new System.Drawing.Point(166, 99);
            this.btnMinStr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinStr.Name = "btnMinStr";
            this.btnMinStr.Size = new System.Drawing.Size(21, 18);
            this.btnMinStr.TabIndex = 5;
            this.btnMinStr.Text = "-";
            this.btnMinStr.UseVisualStyleBackColor = true;
            this.btnMinStr.Click += new System.EventHandler(this.SubtractStrength);
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(110, 99);
            this.txtStrength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.ReadOnly = true;
            this.txtStrength.Size = new System.Drawing.Size(27, 20);
            this.txtStrength.TabIndex = 3;
            this.txtStrength.Text = "50";
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(110, 127);
            this.txtIntelligence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.ReadOnly = true;
            this.txtIntelligence.Size = new System.Drawing.Size(27, 20);
            this.txtIntelligence.TabIndex = 6;
            this.txtIntelligence.Text = "50";
            // 
            // txtAgility
            // 
            this.txtAgility.Location = new System.Drawing.Point(110, 157);
            this.txtAgility.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAgility.Name = "txtAgility";
            this.txtAgility.ReadOnly = true;
            this.txtAgility.Size = new System.Drawing.Size(27, 20);
            this.txtAgility.TabIndex = 9;
            this.txtAgility.Text = "50";
            // 
            // txtConstitution
            // 
            this.txtConstitution.Location = new System.Drawing.Point(110, 186);
            this.txtConstitution.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConstitution.Name = "txtConstitution";
            this.txtConstitution.ReadOnly = true;
            this.txtConstitution.Size = new System.Drawing.Size(27, 20);
            this.txtConstitution.TabIndex = 12;
            this.txtConstitution.Text = "50";
            // 
            // txtCharisma
            // 
            this.txtCharisma.Location = new System.Drawing.Point(110, 212);
            this.txtCharisma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCharisma.Name = "txtCharisma";
            this.txtCharisma.ReadOnly = true;
            this.txtCharisma.Size = new System.Drawing.Size(27, 20);
            this.txtCharisma.TabIndex = 15;
            this.txtCharisma.Text = "50";
            // 
            // btnPlusInt
            // 
            this.btnPlusInt.Location = new System.Drawing.Point(142, 127);
            this.btnPlusInt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusInt.Name = "btnPlusInt";
            this.btnPlusInt.Size = new System.Drawing.Size(21, 18);
            this.btnPlusInt.TabIndex = 7;
            this.btnPlusInt.Text = "+";
            this.btnPlusInt.UseVisualStyleBackColor = true;
            this.btnPlusInt.Click += new System.EventHandler(this.AddInteligence);
            // 
            // btnPlusAgi
            // 
            this.btnPlusAgi.Location = new System.Drawing.Point(142, 157);
            this.btnPlusAgi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusAgi.Name = "btnPlusAgi";
            this.btnPlusAgi.Size = new System.Drawing.Size(21, 18);
            this.btnPlusAgi.TabIndex = 10;
            this.btnPlusAgi.Text = "+";
            this.btnPlusAgi.UseVisualStyleBackColor = true;
            this.btnPlusAgi.Click += new System.EventHandler(this.AddAgility);
            // 
            // btnPlusCon
            // 
            this.btnPlusCon.Location = new System.Drawing.Point(142, 186);
            this.btnPlusCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusCon.Name = "btnPlusCon";
            this.btnPlusCon.Size = new System.Drawing.Size(21, 18);
            this.btnPlusCon.TabIndex = 13;
            this.btnPlusCon.Text = "+";
            this.btnPlusCon.UseVisualStyleBackColor = true;
            this.btnPlusCon.Click += new System.EventHandler(this.AddConstitution);
            // 
            // btnPlusCha
            // 
            this.btnPlusCha.Location = new System.Drawing.Point(142, 212);
            this.btnPlusCha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusCha.Name = "btnPlusCha";
            this.btnPlusCha.Size = new System.Drawing.Size(21, 18);
            this.btnPlusCha.TabIndex = 16;
            this.btnPlusCha.Text = "+";
            this.btnPlusCha.UseVisualStyleBackColor = true;
            this.btnPlusCha.Click += new System.EventHandler(this.AddCharisma);
            // 
            // btnMinInt
            // 
            this.btnMinInt.Location = new System.Drawing.Point(166, 127);
            this.btnMinInt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinInt.Name = "btnMinInt";
            this.btnMinInt.Size = new System.Drawing.Size(21, 18);
            this.btnMinInt.TabIndex = 8;
            this.btnMinInt.Text = "-";
            this.btnMinInt.UseVisualStyleBackColor = true;
            this.btnMinInt.Click += new System.EventHandler(this.SubtractIntelligence);
            // 
            // btnMinAgi
            // 
            this.btnMinAgi.Location = new System.Drawing.Point(166, 157);
            this.btnMinAgi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinAgi.Name = "btnMinAgi";
            this.btnMinAgi.Size = new System.Drawing.Size(21, 18);
            this.btnMinAgi.TabIndex = 11;
            this.btnMinAgi.Text = "-";
            this.btnMinAgi.UseVisualStyleBackColor = true;
            this.btnMinAgi.Click += new System.EventHandler(this.SubtractAgility);
            // 
            // btnMinCon
            // 
            this.btnMinCon.Location = new System.Drawing.Point(166, 186);
            this.btnMinCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinCon.Name = "btnMinCon";
            this.btnMinCon.Size = new System.Drawing.Size(21, 18);
            this.btnMinCon.TabIndex = 14;
            this.btnMinCon.Text = "-";
            this.btnMinCon.UseVisualStyleBackColor = true;
            this.btnMinCon.Click += new System.EventHandler(this.SubtractConstitution);
            // 
            // btnMinCha
            // 
            this.btnMinCha.Location = new System.Drawing.Point(166, 212);
            this.btnMinCha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinCha.Name = "btnMinCha";
            this.btnMinCha.Size = new System.Drawing.Size(21, 18);
            this.btnMinCha.TabIndex = 17;
            this.btnMinCha.Text = "-";
            this.btnMinCha.UseVisualStyleBackColor = true;
            this.btnMinCha.Click += new System.EventHandler(this.SubtractCharisma);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // CharacterCreatorForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(302, 479);
            this.Controls.Add(this.btnMinCha);
            this.Controls.Add(this.btnMinCon);
            this.Controls.Add(this.btnMinAgi);
            this.Controls.Add(this.btnMinInt);
            this.Controls.Add(this.btnPlusCha);
            this.Controls.Add(this.btnPlusCon);
            this.Controls.Add(this.btnPlusAgi);
            this.Controls.Add(this.btnPlusInt);
            this.Controls.Add(this.txtCharisma);
            this.Controls.Add(this.txtConstitution);
            this.Controls.Add(this.txtAgility);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.btnMinStr);
            this.Controls.Add(this.btnPlusStr);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPointsRemaining);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.comboBoxProfession);
            this.Controls.Add(this.richTextDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblProfession);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1450, 928);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(318, 367);
            this.Name = "CharacterCreatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.ComboBox comboBoxProfession;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.TextBox txtPointsRemaining;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPlusStr;
        private System.Windows.Forms.Button btnMinStr;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.TextBox txtAgility;
        private System.Windows.Forms.TextBox txtConstitution;
        private System.Windows.Forms.TextBox txtCharisma;
        private System.Windows.Forms.Button btnPlusInt;
        private System.Windows.Forms.Button btnPlusAgi;
        private System.Windows.Forms.Button btnPlusCon;
        private System.Windows.Forms.Button btnPlusCha;
        private System.Windows.Forms.Button btnMinInt;
        private System.Windows.Forms.Button btnMinAgi;
        private System.Windows.Forms.Button btnMinCon;
        private System.Windows.Forms.Button btnMinCha;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}