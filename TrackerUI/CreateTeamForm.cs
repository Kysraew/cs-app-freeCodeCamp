using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private BindingList<PersonModel> aviliableTeamMembers = new BindingList<PersonModel>(GlobalConfig.Connection.GetPersonAll());
        private BindingList<PersonModel> selectedTeamMembers = new BindingList<PersonModel>();


        public CreateTeamForm()
        {
            //CreateSampleData();
            InitializeComponent();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            aviliableTeamMembers.Add(new PersonModel { FirstName = "Ksaw", LastName = "Wol" });
            aviliableTeamMembers.Add(new PersonModel { FirstName = "Test", LastName = "EEE" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "fgfg", LastName = "Low" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "High" });

        }
        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = aviliableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMemberListBox.DataSource = null;
            teamMemberListBox.DataSource = selectedTeamMembers;
            teamMemberListBox.DisplayMember = "FullName";

        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameTextBox.Text;
                p.LastName = lastNameTextBox.Text;
                p.CellphoneNumber = cellphoneNumberTextBox.Text;
                p.EmailAddress = emailTextBox.Text;

                p = GlobalConfig.Connection.CreatePerson(p);
                aviliableTeamMembers.Add(p);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                cellphoneNumberTextBox.Text = "";
                emailTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all boxes");
            }
        }

        private bool ValidateForm()
        {
            // TODO - Add form validation
            if (firstNameTextBox.Text.Length == 0 ||
                lastNameTextBox.Text.Length == 0 ||
                cellphoneNumberTextBox.Text.Length == 0 ||
                emailTextBox.Text.Length == 0
                )
            {
                return false;
            }

            return true;
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                aviliableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
            }

        }

        private void removeMembersButton_Click(object sender, EventArgs e)
        {
            PersonModel? p = (PersonModel?)teamMemberListBox.SelectedItem;

            if(p != null)
            {
                selectedTeamMembers.Remove(p);
                aviliableTeamMembers.Add(p);
            }
        }
    }
}
