using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Registrator;
using DevExpress.LookAndFeel;
using System.Reflection;
using DevExpress.XtraGrid.Views.Layout.Drawing;
using DevExpress.XtraGrid.Views.Base;
using System.Collections;
using System.Drawing;
using DevExpress.XtraEditors.Controls;


namespace DXSample {
    public class MyLayoutView : LayoutView {
        public MyLayoutView() : base() { }
        public MyLayoutView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override string ViewName { get { return "MyLayoutView"; } }

        protected override void CreateILayoutControlImplementor() {
            FieldInfo fi = typeof(LayoutView).GetField("implementorCore", BindingFlags.Instance | BindingFlags.NonPublic);
            fi.SetValue(this, new MyLayoutViewLayoutControlImplementor(this));
        }
    }

    public class MyLayoutViewLayoutControlImplementor : LayoutViewLayoutControlImplementor {
        public MyLayoutViewLayoutControlImplementor(ILayoutControlOwner owner) : base(owner) { }

        protected override void InitializePaintStyles() {
            base.InitializePaintStyles();
            ISupportLookAndFeel lookAndFeelOwner = owner.GetISupportLookAndFeel();
            if (lookAndFeelOwner != null) {
                PaintStyles.RemoveAt(1);
                PaintStyles.Add(new MyLayoutViewSkinPaintStyle(lookAndFeelOwner, View));
                PropertyInfo pi = typeof(LayoutPaintStyleCollection).GetProperty("List", BindingFlags.Instance | BindingFlags.NonPublic);
                IList list = (IList)pi.GetValue(PaintStyles, null);
                for (int i = 0; i < list.Count; i++)
                    if (((LayoutPaintStyle)list[i]).PaintStyleName == "Skin") {
                        list[i] = new MyLayoutViewSkinPaintStyle(lookAndFeelOwner, View);
                        break;
                    }
                lookAndFeelOwner = null;
            }
        }
    }

    public class MyLayoutViewSkinPaintStyle : LayoutViewSkinPaintStyle {
        public MyLayoutViewSkinPaintStyle(ISupportLookAndFeel owner, LayoutView view) : base(owner, view) { }

        public override string PaintStyleName { get { return "SkinEx"; } }

        public override LayoutRepositoryItemSkinPainter GetRepositoryItemSkinPainter() {
            if (repositoryItemSkinPainter == null) repositoryItemSkinPainter = new MyLayoutRepositoryItemSkinPainter();
            return repositoryItemSkinPainter;
        }
    }

    public class MyLayoutRepositoryItemSkinPainter : LayoutRepositoryItemSkinPainter {
        public MyLayoutRepositoryItemSkinPainter() : base() { }

        protected override void DrawFieldValue(LayoutRepositoryItemViewInfo viewInfo) {
            base.DrawFieldValue(viewInfo);
            Rectangle r = viewInfo.RepositoryItemViewInfo.BorderRect;
            r.Inflate(1, 1);
            viewInfo.Graphics.DrawRectangle(Pens.BurlyWood, r);
        }
    }

    public class MyLayoutInfoRegistrator : DevExpress.XtraGrid.Registrator.LayoutViewInfoRegistrator {
        public MyLayoutInfoRegistrator() : base() { }
        public override string ViewName  { get { return "MyLayoutView"; } }
        public override DevExpress.XtraGrid.Views.Base.BaseView CreateView(GridControl grid) { return new MyLayoutView(grid); }
    }
}