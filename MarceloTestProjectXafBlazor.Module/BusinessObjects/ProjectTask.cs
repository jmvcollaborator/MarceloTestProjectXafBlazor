using System;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace MarceloTestProjectXafBlazor.Module.BusinessObjects
{
    [NavigationItem("Planning")]
    public class ProjectTask : BaseObject
    {
        public ProjectTask(Session session) : base(session) { }
        string subject;
        [Size(255)]
        public string Subject
        {
            get { return subject; }
            set { SetPropertyValue(nameof(Subject), ref subject, value); }
        }
        ProjectTaskStatus status;
        public ProjectTaskStatus Status
        {
            get { return status; }
            set { SetPropertyValue(nameof(Status), ref status, value); }
        }
        Person assignedTo;
        public Person AssignedTo
        {
            get { return assignedTo; }
            set { SetPropertyValue(nameof(AssignedTo), ref assignedTo, value); }
        }
        DateTime startDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set { SetPropertyValue(nameof(startDate), ref startDate, value); }
        }
        DateTime endDate;
        public DateTime EndDate
        {
            get { return endDate; }
            set { SetPropertyValue(nameof(endDate), ref endDate, value); }
        }
        string notes;
        [Size(SizeAttribute.Unlimited)]
        public string Notes
        {
            get { return notes; }
            set { SetPropertyValue(nameof(Notes), ref notes, value); }
        }
        Project project;
        [Association]
        public Project Project
        {
            get { return project; }
            set { SetPropertyValue(nameof(Project), ref project, value); }
        }
    }
    // ...
}
