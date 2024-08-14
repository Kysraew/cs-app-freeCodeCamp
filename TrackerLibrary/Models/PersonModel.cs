using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models

{
    /// <summary>
    /// Represents person in the tournament
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents first name of the person
        /// </summary>
        public int Id { get; set; }
        public string FirstName { get; set; }
        /// <summary>
        /// Represents last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents email of the person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents cellphone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
