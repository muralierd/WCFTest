using System.Runtime.Serialization;

namespace WcfServiceTestLibrary
{
    [DataContract]
    public class EmployeeDetails
    {
        [DataMember]
        public string EmpId { get; set; }
        [DataMember]
        public string EmpName { get; set; }
        [DataMember]
        public string Address1 { get; set; }
        [DataMember]
        public string Address2 { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public long Pincode { get; set; }


    }
}
