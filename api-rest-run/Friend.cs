using System;
namespace api_rest_run
{
	public class Friend
	{
		public string firstname { get; set; }
        public string lasttname { get; set; }
        public string location { get; set; }
        private DateTime dateOfHire { get; set; }


        public Friend()
		{
		}

        public Friend(string firstname, string lasttname, string location, DateTime dateOfHire)
        {
            this.firstname = firstname;
            this.lasttname = lasttname;
            this.location = location;
            this.dateOfHire = dateOfHire;
        }
    }
}

