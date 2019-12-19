﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WinFormMVVM.ViewModels;

namespace WinFormMVVM.Views
{
    public partial class TrackView : DevExpress.XtraEditors.XtraUserControl
    {
        public TrackView()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var f = mvvmContext1.OfType<TrackViewModel>();
            f.SetBinding(textEditID, x => x.EditValue, x => x.TrackId);
            f.SetBinding(textEditName, x => x.EditValue, x => x.Name);
            f.SetBinding(textEditComposer, x => x.EditValue, x => x.Composer);
            f.BindCommand(btnClear, x => x.ResetName());
            f.BindCommand(btnSave, x => x.Save());
            f.BindCommand(btnCancel, x => x.Revert());
        }
    }
}
