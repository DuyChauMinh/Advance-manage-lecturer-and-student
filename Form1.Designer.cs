namespace Coding
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.listBoxPatient = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBoxPatient = new System.Windows.Forms.PictureBox();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxPatientrecord = new System.Windows.Forms.TextBox();
            this.textBoxDateofbirth = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.labelPatientrecord = new System.Windows.Forms.Label();
            this.labelDateofbirth = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelPatientManagement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(171, 434);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(136, 26);
            this.textBoxSearch.TabIndex = 50;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Full name",
            "Address",
            "Telephone",
            "Date of birth"});
            this.comboBoxSearch.Location = new System.Drawing.Point(40, 433);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(125, 26);
            this.comboBoxSearch.TabIndex = 49;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(37, 387);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(159, 18);
            this.labelSearch.TabIndex = 48;
            this.labelSearch.Text = "Searching solution";
            // 
            // listBoxPatient
            // 
            this.listBoxPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPatient.FormattingEnabled = true;
            this.listBoxPatient.ItemHeight = 18;
            this.listBoxPatient.Location = new System.Drawing.Point(500, 317);
            this.listBoxPatient.Name = "listBoxPatient";
            this.listBoxPatient.Size = new System.Drawing.Size(245, 130);
            this.listBoxPatient.TabIndex = 47;
            this.listBoxPatient.SelectedIndexChanged += new System.EventHandler(this.listBoxPatient_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(630, 467);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 27);
            this.buttonUpdate.TabIndex = 46;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(513, 467);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 27);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(313, 433);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 27);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBoxPatient
            // 
            this.pictureBoxPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPatient.Location = new System.Drawing.Point(500, 53);
            this.pictureBoxPatient.Name = "pictureBoxPatient";
            this.pictureBoxPatient.Size = new System.Drawing.Size(246, 258);
            this.pictureBoxPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPatient.TabIndex = 43;
            this.pictureBoxPatient.TabStop = false;
            this.pictureBoxPatient.Click += new System.EventHandler(this.pictureBoxPatient_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(313, 332);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(94, 27);
            this.buttonLast.TabIndex = 42;
            this.buttonLast.Text = ">>|";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(222, 332);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(94, 27);
            this.buttonNext.TabIndex = 41;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(131, 332);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 27);
            this.buttonPrevious.TabIndex = 40;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(40, 332);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(94, 27);
            this.buttonFirst.TabIndex = 39;
            this.buttonFirst.Text = "|<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(327, 192);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(80, 22);
            this.radioButtonFemale.TabIndex = 38;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(199, 194);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(60, 22);
            this.radioButtonMale.TabIndex = 37;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxPatientrecord
            // 
            this.textBoxPatientrecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPatientrecord.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientrecord.Location = new System.Drawing.Point(199, 285);
            this.textBoxPatientrecord.Name = "textBoxPatientrecord";
            this.textBoxPatientrecord.Size = new System.Drawing.Size(208, 26);
            this.textBoxPatientrecord.TabIndex = 36;
            // 
            // textBoxDateofbirth
            // 
            this.textBoxDateofbirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateofbirth.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateofbirth.Location = new System.Drawing.Point(199, 241);
            this.textBoxDateofbirth.Name = "textBoxDateofbirth";
            this.textBoxDateofbirth.Size = new System.Drawing.Size(208, 26);
            this.textBoxDateofbirth.TabIndex = 35;
            this.textBoxDateofbirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDateofbirth_KeyPress);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTelephone.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.Location = new System.Drawing.Point(199, 144);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(208, 26);
            this.textBoxTelephone.TabIndex = 34;
            this.textBoxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelephone_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(199, 97);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(208, 26);
            this.textBoxAddress.TabIndex = 33;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFullname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullname.Location = new System.Drawing.Point(199, 53);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(208, 26);
            this.textBoxFullname.TabIndex = 32;
            this.textBoxFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFullname_KeyPress);
            // 
            // labelPatientrecord
            // 
            this.labelPatientrecord.AutoSize = true;
            this.labelPatientrecord.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientrecord.Location = new System.Drawing.Point(37, 288);
            this.labelPatientrecord.Name = "labelPatientrecord";
            this.labelPatientrecord.Size = new System.Drawing.Size(128, 18);
            this.labelPatientrecord.TabIndex = 31;
            this.labelPatientrecord.Text = "Patient Record";
            // 
            // labelDateofbirth
            // 
            this.labelDateofbirth.AutoSize = true;
            this.labelDateofbirth.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateofbirth.Location = new System.Drawing.Point(37, 241);
            this.labelDateofbirth.Name = "labelDateofbirth";
            this.labelDateofbirth.Size = new System.Drawing.Size(113, 18);
            this.labelDateofbirth.TabIndex = 30;
            this.labelDateofbirth.Text = "Date of birth";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(37, 194);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(37, 18);
            this.labelSex.TabIndex = 29;
            this.labelSex.Text = "Sex";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelephone.Location = new System.Drawing.Point(37, 147);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(93, 18);
            this.labelTelephone.TabIndex = 28;
            this.labelTelephone.Text = "Telephone";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(37, 100);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(73, 18);
            this.labelAddress.TabIndex = 27;
            this.labelAddress.Text = "Address";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.Location = new System.Drawing.Point(37, 53);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(88, 18);
            this.labelFullname.TabIndex = 26;
            this.labelFullname.Text = "Full name";
            // 
            // labelPatientManagement
            // 
            this.labelPatientManagement.AutoSize = true;
            this.labelPatientManagement.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientManagement.Location = new System.Drawing.Point(279, 9);
            this.labelPatientManagement.Name = "labelPatientManagement";
            this.labelPatientManagement.Size = new System.Drawing.Size(257, 25);
            this.labelPatientManagement.TabIndex = 25;
            this.labelPatientManagement.Text = "Patient Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBoxPatient);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pictureBoxPatient);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxPatientrecord);
            this.Controls.Add(this.textBoxDateofbirth);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFullname);
            this.Controls.Add(this.labelPatientrecord);
            this.Controls.Add(this.labelDateofbirth);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.labelPatientManagement);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListBox listBoxPatient;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxPatient;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxPatientrecord;
        private System.Windows.Forms.TextBox textBoxDateofbirth;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.Label labelPatientrecord;
        private System.Windows.Forms.Label labelDateofbirth;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelPatientManagement;
    }
}

