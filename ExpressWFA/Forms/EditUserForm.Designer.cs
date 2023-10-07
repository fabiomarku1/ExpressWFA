using ExpressWFA.Shared.Types;
using System;

namespace ExpressWFA.Forms
{
    partial class EditUserForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.dirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.isEmployedCheck = new System.Windows.Forms.CheckBox();
            this.birthPlaceBox = new System.Windows.Forms.TextBox();
            this.martialStatusList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(127, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "RUAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edit User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(56, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emer Mbiemer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datelindja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gjinia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Gjendja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Vendlindja";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(191, 94);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(74, 20);
            this.firstNameBox.TabIndex = 3;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(271, 94);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(88, 20);
            this.lastNameBox.TabIndex = 3;
            // 
            // dirthdayPicker
            // 
            this.dirthdayPicker.CustomFormat = "\"dd-mm-yyyy\"";
            this.dirthdayPicker.Location = new System.Drawing.Point(179, 130);
            this.dirthdayPicker.Name = "dirthdayPicker";
            this.dirthdayPicker.Size = new System.Drawing.Size(199, 20);
            this.dirthdayPicker.TabIndex = 4;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(191, 168);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(168, 20);
            this.phoneBox.TabIndex = 3;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(191, 206);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(54, 17);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "MALE";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(292, 206);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(67, 17);
            this.femaleRadio.TabIndex = 6;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "FEMALE";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // isEmployedCheck
            // 
            this.isEmployedCheck.AutoSize = true;
            this.isEmployedCheck.Location = new System.Drawing.Point(227, 239);
            this.isEmployedCheck.Name = "isEmployedCheck";
            this.isEmployedCheck.Size = new System.Drawing.Size(83, 17);
            this.isEmployedCheck.TabIndex = 7;
            this.isEmployedCheck.Text = "I Punesuar?";
            this.isEmployedCheck.UseVisualStyleBackColor = true;
            // 
            // birthPlaceBox
            // 
            this.birthPlaceBox.Location = new System.Drawing.Point(191, 326);
            this.birthPlaceBox.Name = "birthPlaceBox";
            this.birthPlaceBox.Size = new System.Drawing.Size(168, 20);
            this.birthPlaceBox.TabIndex = 3;
            // 
            // martialStatusList
            // 
            this.martialStatusList.AutoCompleteCustomSource.AddRange(new string[] {
            "SELECT"});
            this.martialStatusList.DataSource = new ExpressWFA.Shared.Types.MartialStatus[] {
        ExpressWFA.Shared.Types.MartialStatus.Married,
        ExpressWFA.Shared.Types.MartialStatus.Divorced,
        ExpressWFA.Shared.Types.MartialStatus.Single,
        ExpressWFA.Shared.Types.MartialStatus.Widow};
            this.martialStatusList.FormattingEnabled = true;
            this.martialStatusList.DataSource = Enum.GetValues(typeof(MartialStatus));
            this.martialStatusList.Location = new System.Drawing.Point(191, 273);
            this.martialStatusList.Name = "martialStatusList";
            this.martialStatusList.Size = new System.Drawing.Size(168, 21);
            this.martialStatusList.TabIndex = 8;
            this.martialStatusList.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "martesore";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(417, 464);
            this.Controls.Add(this.martialStatusList);
            this.Controls.Add(this.isEmployedCheck);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.dirthdayPicker);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.birthPlaceBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "EditUserForm";
            this.Text = "Emri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.DateTimePicker dirthdayPicker;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.CheckBox isEmployedCheck;
        private System.Windows.Forms.TextBox birthPlaceBox;
        private System.Windows.Forms.ComboBox martialStatusList;
        private System.Windows.Forms.Label label3;
    }
}