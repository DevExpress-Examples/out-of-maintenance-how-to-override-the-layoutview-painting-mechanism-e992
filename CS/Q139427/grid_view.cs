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
            ISupportLookAndFeel lookAndFeelOwner = owner.GetISupportLookAndFeel();
            if (lookAndFeelOwner != null) {
                PaintStyles.Add(new MyLayoutViewSkinPaintStyle(lookAndFeelOwner, View));
                PaintStyles.Add(new LayoutWindowsXPPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new LayoutViewOffice2003PaintStyle(lookAndFeelOwner, View));
                PaintStyles.Add(new LayoutViewStyle3DPaintStyle(lookAndFeelOwner, View));
                PaintStyles.Add(new LayoutViewUltraFlatPaintStyle(lookAndFeelOwner, View));
                PaintStyles.Add(new LayoutViewFlatPaintStyle(lookAndFeelOwner, View));
            }
            lookAndFeelOwner = null;
        }
    }

    public class MyLayoutViewSkinPaintStyle : LayoutViewSkinPaintStyle {
        public MyLayoutViewSkinPaintStyle(ISupportLookAndFeel owner, LayoutView view) : base(owner, view) { }

        public override DevExpress.XtraLayout.Painting.BaseLayoutItemPainter GetPainter(BaseLayoutItem item) {
            return base.GetPainter(item);
        }

        MyLayoutViewFieldSkinPainter cardFieldPainter = null;
        public override LayoutViewFieldSkinPainter GetFieldPainter() {
            if (cardFieldPainter == null) cardFieldPainter = new MyLayoutViewFieldSkinPainter(View);
            return cardFieldPainter;
        }
    }

    public class MyLayoutViewFieldSkinPainter :LayoutViewFieldSkinPainter {
        public MyLayoutViewFieldSkinPainter(LayoutView layoutView) : base(layoutView) { }

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