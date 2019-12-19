using DevExpress.XtraEditors;

namespace WinFormMVVM.Views
{
    partial class TrackView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textEditComposer = new DevExpress.XtraEditors.TextEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditComposer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditComposer
            // 
            this.textEditComposer.Location = new System.Drawing.Point(118, 159);
            this.textEditComposer.Name = "textEditComposer";
            this.textEditComposer.Size = new System.Drawing.Size(164, 20);
            this.textEditComposer.TabIndex = 2;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(118, 133);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(164, 20);
            this.textEditName.TabIndex = 1;
            // 
            // textEditID
            // 
            this.textEditID.Location = new System.Drawing.Point(118, 107);
            this.textEditID.Name = "textEditID";
            this.textEditID.Size = new System.Drawing.Size(164, 20);
            this.textEditID.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Name";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterMessageBoxService(null, false, DevExpress.Utils.MVVM.Services.DefaultMessageBoxServiceType.Default)});
            this.mvvmContext1.ViewModelType = typeof(WinFormMVVM.ViewModels.TrackViewModel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // TrackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textEditComposer);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.textEditID);
            this.Name = "TrackView";
            this.Size = new System.Drawing.Size(406, 313);
            ((System.ComponentModel.ISupportInitialize)(this.textEditComposer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private TextEdit textEditComposer;
        private TextEdit textEditName;
        private TextEdit textEditID;
        private SimpleButton btnClear;
        private SimpleButton btnCancel;
        private SimpleButton btnSave;
    }
}
