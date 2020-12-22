using System;

namespace KomodoInsuranceRepository
{
    public class DevTeam
    {
        public string TeamMembers { get; set; }
        public string TeamName { get; set; }
        public string TeamID { get; set; }

    }
    public class Developers
    {
        public string DeveloperName { get; set; }

        public string IdNumber { get; set; }

        public bool HasAccess { get; set; }

        public Developers () { }

        public Developers(string developerName, string idNumber, bool hasAccess) 
        {
            DeveloperName = developerName;
            IdNumber = idNumber;
            HasAccess = hasAccess;
        }

    }

    class DeveloperRepo
    {
    
    }
    
    class DevTeamRepo
    {
    
    }

}
