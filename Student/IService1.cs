using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Student
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Student> AllStudents();

        [OperationContract]
        Student GetStudent(int id);

        [OperationContract]
        string AddStudent(Student student);

        [OperationContract]
        string UpdateStudent(Student student);

        [OperationContract]
        string DeleteStudent(int id);
       
        [OperationContract]
        List<Attendance> AllAttendance();

        [OperationContract]
        string AddAttendance(Attendance attendance);

        [OperationContract]
        string DeleteAttendance(int id);

        // TODO: Add your service operations here
    }

 

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Student.ContractType".
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StdId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Education { get; set; }

        [DataMember]
        public DateTime DOB { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public DateTime AddDate { get; set; }

        [DataMember]
        public string Address { get; set; }

    }

    public class Attendance
    {
        [DataMember]
        public int AttendanceId { get; set; }

        [DataMember]
        public int StuId { get; set; }

        [DataMember]
        public string attendance { get; set; }
    }



    public class Grade
    {

        [DataMember]
        public int GradeId { get; set; }

        [DataMember]
        public string grade { get; set; }

        [DataMember]
        public string Sub { get; set; }

    }


}
