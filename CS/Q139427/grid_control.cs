using DevExpress.XtraGrid;

namespace DXSample {
    public class MyGridControl : GridControl {
        public MyGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(DevExpress.XtraGrid.Registrator.InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyLayoutInfoRegistrator());
        }
    }
}