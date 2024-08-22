using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamsModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<PersonModel> persons = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find the max ID
            int currentId = 0;
            if (persons.Count > 0)
            {
                currentId = persons.OrderByDescending(x => x.Id).First().Id;
            }

            // Add the new rocord with the new ID
            model.Id = currentId + 1;
            persons.Add(model);

            // Convert the prizes to list<strings>
            // Save the list<string> to the text file
            persons.SaveToPeopleFile(PeopleFile);
            return model;
        }

        //TODO - Wire up the CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 0;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id;
            }

            // Add the new rocord with the new ID
            model.Id = currentId + 1;
            prizes.Add(model);

            // Convert the prizes to list<strings>
            // Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            int currentId = 0;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id;
            }

            model.Id= currentId + 1;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public List<PersonModel> GetPersonAll()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeamAll()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }
    }
}
