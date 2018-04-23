using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Data.Filtering;

namespace WinSample.Module {
    [DefaultClassOptions]
    public class Master : BaseObject {
        public Master(Session session) : base(session) { }
        private string _MasterName;
        public string MasterName {
            get { return _MasterName; }
            set { SetPropertyValue("MasterName", ref _MasterName, value); }
        }
        [Association("Master-Details")]
        public XPCollection<Detail> Details {
            get {
                return GetCollection<Detail>("Details");
            }
        }
        private XPCollection<SubDetail> _SubDetails;
        public XPCollection<SubDetail> SubDetails {
            get {
                if (_SubDetails == null) {
                    UpdateSubDetails();
                }
                return _SubDetails;
            }
        }
        public void UpdateSubDetails() {
            if (Details.Count > 0) {
                _SubDetails = new XPCollection<SubDetail>(Session, new InOperator("Detail", Details));
            } else {
                _SubDetails = null;
            }
        }
        protected override XPCollection<T> CreateCollection<T>(DevExpress.Xpo.Metadata.XPMemberInfo property) {
            XPCollection<T> collection = base.CreateCollection<T>(property);
            if (property.Name == "Details") {
                collection.CollectionChanged += new XPCollectionChangedEventHandler(Details_CollectionChanged);
            }
            return collection;
        }
        void Details_CollectionChanged(object sender, XPCollectionChangedEventArgs e) {
            UpdateSubDetails();
            OnChanged("SubDetails");
        }
    }

}