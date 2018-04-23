using System;
using System.ComponentModel;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinSample.Module {
    [DefaultClassOptions]
    public class SubDetail : BaseObject {
        public SubDetail(Session session) : base(session) { }
        private string _SubDetailName;
        public string SubDetailName {
            get { return _SubDetailName; }
            set { SetPropertyValue("SubDetailName", ref _SubDetailName, value); }
        }
        private Detail _Detail;
        [Association("Details-SubDetails")]
        public Detail Detail {
            get { return _Detail; }
            set { SetPropertyValue("Detail", ref _Detail, value); }
        }
    }

}
