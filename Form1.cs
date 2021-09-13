using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string[] Fullname = new string[30];
        string[] Address = new string[30];
        string[] Telephone = new string[30];
        string[] Sex = new string[30];
        string[] Dateofbirth = new string[30];
        string[] Patientrecord = new string[30];
        Image[] Patientimage = new Image[30];
        int Patientnumber = 0;
        int currentPatient = 0;

        public OpenFileDialog OpenFileDialogPatientimage { get; private set; }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Patientnumber++;
            currentPatient = Patientnumber;
            Fullname[Patientnumber] = textBoxFullname.Text;
            Address[Patientnumber] = textBoxAddress.Text;
            Telephone[Patientnumber] = textBoxTelephone.Text;
            Dateofbirth[Patientnumber] = textBoxDateofbirth.Text;
            Patientrecord[Patientnumber] = textBoxPatientrecord.Text;
            if (radioButtonMale.Checked == true)
            {
                Sex[Patientnumber] = radioButtonMale.Text;
            }
            else
            {
                Sex[Patientnumber] = radioButtonFemale.Text;
            }
            Patientimage[Patientnumber] = pictureBoxPatient.Image;
            listBoxPatient.Items.Add(Fullname[Patientnumber]);
        }
        private void displayPatient(int number)
        {
            textBoxFullname.Text = Fullname[number];
            textBoxAddress.Text = Address[number];
            textBoxTelephone.Text = Telephone[number];
            textBoxDateofbirth.Text = Dateofbirth[number];
            textBoxPatientrecord.Text = Patientrecord[number];
            pictureBoxPatient.Image = Patientimage[number];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Fullname[currentPatient] = textBoxFullname.Text;
            Address[currentPatient] = textBoxAddress.Text;
            Telephone[currentPatient] = textBoxTelephone.Text;
            Dateofbirth[currentPatient] = textBoxDateofbirth.Text;
            Patientrecord[currentPatient] = textBoxPatientrecord.Text;
            if (radioButtonMale.Checked) Sex[currentPatient] = "Male";
            if (radioButtonFemale.Checked) Sex[currentPatient] = "Female";
            Patientimage[currentPatient] = pictureBoxPatient.Image;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            currentPatient = 1;
            displayPatient(currentPatient);
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            currentPatient = Patientnumber;
            displayPatient(currentPatient);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentPatient > 1)
            {
                currentPatient--;
                displayPatient(currentPatient);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentPatient < Patientnumber)
            {
                currentPatient++;
                displayPatient(currentPatient);
            }
        }

        private void listBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPatient = listBoxPatient.SelectedIndex + 1;
            displayPatient(currentPatient);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            switch (comboBoxSearch.Text)
            {
                case "Full name":
                    for (int i = 1; i <= Patientnumber; i++)
                    {
                        if (textBoxSearch.Text == Fullname[i])
                        {
                            displayPatient(i);
                        }
                    }
                    break;
                case "Address":
                    for (int i = 1; i <= Patientnumber; i++)
                    {
                        if (textBoxSearch.Text == Address[i])
                        {
                            displayPatient(i);

                        }
                    }
                    break;
                case "Telephone":
                    for (int i = 1; i <= Patientnumber; i++)
                    {
                        if (textBoxSearch.Text == Telephone[i])
                        {
                            displayPatient(i);

                        }
                    }
                    break;
                case "Date of birth":
                    for (int i = 1; i <= Patientnumber; i++)
                    {
                        if (textBoxSearch.Text == Dateofbirth[i])
                        {
                            displayPatient(i);

                        }
                    }
                    break;
            }
        }

        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("ONLY INPUT NUMBERS !");
                e.Handled = true;
            }
            if (textBoxTelephone.Text.Length >= 11)
            {
                e.Handled = true;
            }
        }

        private void textBoxFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ONLY INPUT WORDS !");
            }
        }

        private void textBoxDateofbirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 47 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar == 92 || e.KeyChar == 95);
            ///47->57 symbol / and  number 0->9 , 8 is backspace, 45 is -, 92 is \, 95 is _
            if (textBoxDateofbirth.Text.Length >= 10)
            {
                e.Handled = true;

            }
        }

        private void pictureBoxPatient_Click(object sender, EventArgs e)
        {
            OpenFileDialogPatientimage = new OpenFileDialog();
            OpenFileDialogPatientimage.ShowDialog();
            pictureBoxPatient.Image = Image.FromFile(OpenFileDialogPatientimage.FileName);
        }
    }
    }

   