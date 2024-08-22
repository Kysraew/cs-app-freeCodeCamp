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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        BindingList<TeamModel> aviliableTeams = new BindingList<TeamModel>(GlobalConfig.Connection.GetTeamAll());
        BindingList<TeamModel> selectedTeams = new BindingList<TeamModel>();
        BindingList<PrizeModel> selectedPrizes = new BindingList<PrizeModel>();


        public CreateTournamentForm()
        {
            InitializeComponent();

            InitializeLists();
        }

        private void InitializeLists()
        {
            teamsDropDown.DataSource = aviliableTeams;
            teamsDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PrizeName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel? t = (TeamModel?)teamsDropDown.SelectedItem;

            if (t != null)
            {
                selectedTeams.Add(t);
                aviliableTeams.Remove(t);
            }
        }

        private void deletePlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel? t = (TeamModel?)tournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                aviliableTeams.Add(t);
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
        }

        public void TeamComplete(TeamModel model)
        {
            aviliableTeams.Add(model);
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void deletePrizessButton_Click(object sender, EventArgs e)
        {
            PrizeModel? p = (PrizeModel?)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
            }
        }
    }
}

