using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.ComponentModel;
using WinFormMVVM.Data;

namespace WinFormMVVM.ViewModels
{
    [POCOViewModel]
    public class TrackViewModel : IEditableObject
    {
        private TrackInfo _track;
        private TrackInfo trackInfo;

        private void Load(TrackInfo track)
        {
            this._track = track;
            this.TrackId = _track.TrackId;
            this.Name = _track.Name;
            this.Composer = _track.Composer;
        }
        private void Store()
        {
            if (TrackId != _track.TrackId)
                _track.TrackId = TrackId;
            if (!string.Equals(Name, _track.Name))
                _track.Name = Name;
            if (!string.Equals(Composer, _track.Composer))
                _track.Composer = Composer;
        }
        public virtual int TrackId { get; set; }
        public virtual string Name { get; set; }
        protected void OnNameChange()
        {
            this.RaiseCanExecuteChanged(x => x.ResetName());
        }
        public virtual string Composer { get; set; }
        //protected TrackViewModel()
        //{
        //    Load(new TrackList()[10]);
        //}
        protected TrackViewModel() : this(new TrackList()[10]) { }

        protected TrackViewModel(TrackInfo track)
        {
            if (track == null)
                throw new ArgumentNullException("track", "track is null");
            Load(track);
        }
        public static TrackViewModel Create()
        {
            return ViewModelSource.Create(() => new TrackViewModel());
        }
        public static TrackViewModel Create(TrackInfo track)
        {
            return ViewModelSource.Create(() => new TrackViewModel(track ));
        }
        public void ResetName()
        {
            if(MessageBoxService.ShowMessage("Are you sure you want to reset the Name value?", 
                "Question",
                MessageButton.YesNo, 
                MessageIcon.Question, 
                MessageResult.No) == MessageResult.Yes)
                this.Name = "";
        }
        public bool CanResetName()
        {
            return !string.IsNullOrEmpty(this.Name);
        }
        void IEditableObject.BeginEdit()
        {
        }

        void IEditableObject.EndEdit()
        {
            Store();
        }

        void IEditableObject.CancelEdit()
        {
            Load(_track);
        }

        [ServiceProperty(SearchMode = DevExpress.Mvvm.ServiceSearchMode.PreferParents)]
        protected virtual IMessageBoxService MessageBoxService { get { return null; } }

        public void Save() { ((IEditableObject)this).EndEdit(); }
        public void Revert() { ((IEditableObject)this).CancelEdit(); }
    }
}