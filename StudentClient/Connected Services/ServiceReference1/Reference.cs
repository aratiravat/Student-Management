﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/Student")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AddDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EducationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StdIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AddDate {
            get {
                return this.AddDateField;
            }
            set {
                if ((this.AddDateField.Equals(value) != true)) {
                    this.AddDateField = value;
                    this.RaisePropertyChanged("AddDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((this.DOBField.Equals(value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Education {
            get {
                return this.EducationField;
            }
            set {
                if ((object.ReferenceEquals(this.EducationField, value) != true)) {
                    this.EducationField = value;
                    this.RaisePropertyChanged("Education");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StdId {
            get {
                return this.StdIdField;
            }
            set {
                if ((this.StdIdField.Equals(value) != true)) {
                    this.StdIdField = value;
                    this.RaisePropertyChanged("StdId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Attendance", Namespace="http://schemas.datacontract.org/2004/07/Student")]
    [System.SerializableAttribute()]
    public partial class Attendance : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AttendanceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StuIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string attendanceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AttendanceId {
            get {
                return this.AttendanceIdField;
            }
            set {
                if ((this.AttendanceIdField.Equals(value) != true)) {
                    this.AttendanceIdField = value;
                    this.RaisePropertyChanged("AttendanceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StuId {
            get {
                return this.StuIdField;
            }
            set {
                if ((this.StuIdField.Equals(value) != true)) {
                    this.StuIdField = value;
                    this.RaisePropertyChanged("StuId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string attendance {
            get {
                return this.attendanceField;
            }
            set {
                if ((object.ReferenceEquals(this.attendanceField, value) != true)) {
                    this.attendanceField = value;
                    this.RaisePropertyChanged("attendance");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AllStudents", ReplyAction="http://tempuri.org/IService1/AllStudentsResponse")]
        StudentClient.ServiceReference1.Student[] AllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AllStudents", ReplyAction="http://tempuri.org/IService1/AllStudentsResponse")]
        System.Threading.Tasks.Task<StudentClient.ServiceReference1.Student[]> AllStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudent", ReplyAction="http://tempuri.org/IService1/GetStudentResponse")]
        StudentClient.ServiceReference1.Student GetStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudent", ReplyAction="http://tempuri.org/IService1/GetStudentResponse")]
        System.Threading.Tasks.Task<StudentClient.ServiceReference1.Student> GetStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        string AddStudent(StudentClient.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        System.Threading.Tasks.Task<string> AddStudentAsync(StudentClient.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateStudent", ReplyAction="http://tempuri.org/IService1/UpdateStudentResponse")]
        string UpdateStudent(StudentClient.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateStudent", ReplyAction="http://tempuri.org/IService1/UpdateStudentResponse")]
        System.Threading.Tasks.Task<string> UpdateStudentAsync(StudentClient.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudent", ReplyAction="http://tempuri.org/IService1/DeleteStudentResponse")]
        string DeleteStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudent", ReplyAction="http://tempuri.org/IService1/DeleteStudentResponse")]
        System.Threading.Tasks.Task<string> DeleteStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AllAttendance", ReplyAction="http://tempuri.org/IService1/AllAttendanceResponse")]
        StudentClient.ServiceReference1.Attendance[] AllAttendance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AllAttendance", ReplyAction="http://tempuri.org/IService1/AllAttendanceResponse")]
        System.Threading.Tasks.Task<StudentClient.ServiceReference1.Attendance[]> AllAttendanceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAttendance", ReplyAction="http://tempuri.org/IService1/AddAttendanceResponse")]
        string AddAttendance(StudentClient.ServiceReference1.Attendance attendance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAttendance", ReplyAction="http://tempuri.org/IService1/AddAttendanceResponse")]
        System.Threading.Tasks.Task<string> AddAttendanceAsync(StudentClient.ServiceReference1.Attendance attendance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAttendance", ReplyAction="http://tempuri.org/IService1/DeleteAttendanceResponse")]
        string DeleteAttendance(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAttendance", ReplyAction="http://tempuri.org/IService1/DeleteAttendanceResponse")]
        System.Threading.Tasks.Task<string> DeleteAttendanceAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : StudentClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<StudentClient.ServiceReference1.IService1>, StudentClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public StudentClient.ServiceReference1.Student[] AllStudents() {
            return base.Channel.AllStudents();
        }
        
        public System.Threading.Tasks.Task<StudentClient.ServiceReference1.Student[]> AllStudentsAsync() {
            return base.Channel.AllStudentsAsync();
        }
        
        public StudentClient.ServiceReference1.Student GetStudent(int id) {
            return base.Channel.GetStudent(id);
        }
        
        public System.Threading.Tasks.Task<StudentClient.ServiceReference1.Student> GetStudentAsync(int id) {
            return base.Channel.GetStudentAsync(id);
        }
        
        public string AddStudent(StudentClient.ServiceReference1.Student student) {
            return base.Channel.AddStudent(student);
        }
        
        public System.Threading.Tasks.Task<string> AddStudentAsync(StudentClient.ServiceReference1.Student student) {
            return base.Channel.AddStudentAsync(student);
        }
        
        public string UpdateStudent(StudentClient.ServiceReference1.Student student) {
            return base.Channel.UpdateStudent(student);
        }
        
        public System.Threading.Tasks.Task<string> UpdateStudentAsync(StudentClient.ServiceReference1.Student student) {
            return base.Channel.UpdateStudentAsync(student);
        }
        
        public string DeleteStudent(int id) {
            return base.Channel.DeleteStudent(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteStudentAsync(int id) {
            return base.Channel.DeleteStudentAsync(id);
        }
        
        public StudentClient.ServiceReference1.Attendance[] AllAttendance() {
            return base.Channel.AllAttendance();
        }
        
        public System.Threading.Tasks.Task<StudentClient.ServiceReference1.Attendance[]> AllAttendanceAsync() {
            return base.Channel.AllAttendanceAsync();
        }
        
        public string AddAttendance(StudentClient.ServiceReference1.Attendance attendance) {
            return base.Channel.AddAttendance(attendance);
        }
        
        public System.Threading.Tasks.Task<string> AddAttendanceAsync(StudentClient.ServiceReference1.Attendance attendance) {
            return base.Channel.AddAttendanceAsync(attendance);
        }
        
        public string DeleteAttendance(int id) {
            return base.Channel.DeleteAttendance(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAttendanceAsync(int id) {
            return base.Channel.DeleteAttendanceAsync(id);
        }
    }
}