using System;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public class User : EndpointModelBase, IDsoUser
    {
        [ItemId]
        public Guid? UserID { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [ReadOnly]
        public DateTime UpdatedDateUTC { get; set; }

        [ReadOnly]
        public bool IsSubscriber { get; set; }

        [ReadOnly]
        public string OrganisationRole { get; set; }


        public string FullName
        {
            get { return string.Concat(FirstName, " ", LastName); }
        }
    }
}
