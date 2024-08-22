using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            
            return File.ReadAllLines(file).ToList();
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PrizeNumber = int.Parse(cols[1]);
                p.PrizeName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber= cols[4];

                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFile)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel p = new TeamModel();
                p.Id = int.Parse(cols[0]);
                p.TeamName = cols[1];

                string[] PersonIds = cols[2].Split('|');
               
                foreach (string personId in PersonIds)
                {
                    p.TeamMembers.Add(people.Where(x => x.Id == int.Parse(personId)).First());
                }

                //Alternative when we allow that id is not on the list
                //p.TeamMembers.AddRange(people.Where(x => PersonIds.Contains(x.ToString())));

                output.Add(p);
            }

            return output;
        }
        
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PrizeNumber},{p.PrizeName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel p in models)
            {
                StringBuilder memberIds = new StringBuilder();

                if (p.TeamMembers.Count > 0)
                {
                    foreach (PersonModel personModel in p.TeamMembers)
                    {
                        memberIds.Append($"{personModel.Id}|");
                    }
                    memberIds.Remove(memberIds.Length - 1, 1);
                }
                
                lines.Add($"{p.Id},{p.TeamName},{memberIds.ToString()}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static int LineToId(this string line)
        {
            return int.Parse(line.Split(',')[0]);
        }
    }

}
