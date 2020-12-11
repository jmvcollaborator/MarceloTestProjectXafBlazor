using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace MarceloTestProjectXafBlazor.Module.BusinessObjects
{
    [NavigationItem("Marketing")]
    public class Testimonial : BaseObject
    {
        public Testimonial(Session session) : base(session)
        {
            createdOn = DateTime.Now;
        }

        /// <summary>
        /// https://docs.devexpress.com/eXpressAppFramework/401954/getting-started/basic-tutorial-blazor/customize-the-application-ui-and-behavior-blazor
        /// </summary>
        string quote;
        [Size(FieldSizeAttribute.Unlimited)]

        public string Quote
        {
            get { return quote; }
            set { SetPropertyValue(nameof(Quote), ref quote, value); }
        }
        string highlight;
        [Size(512)]
        public string Highlight
        {
            get { return highlight; }
            set { SetPropertyValue(nameof(Highlight), ref highlight, value); }
        }
        DateTime createdOn;
        [VisibleInListView(false)]
        public DateTime CreatedOn
        {
            get { return createdOn; }
            internal set { SetPropertyValue(nameof(CreatedOn), ref createdOn, value); }
        }
        string tags;
        public string Tags
        {
            get { return tags; }
            set { SetPropertyValue(nameof(Tags), ref tags, value); }
        }
        Customer customer;
        [Association("Customer-Testimonials")]
        public Customer Customer
        {
            get { return customer; }
            set { SetPropertyValue(nameof(Customer), ref customer, value); }
        }
    }
}
