using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMVVM.Data
{
    public class TrackInfo : INotifyPropertyChanged
    {
        private int trackId;
        private string name;
        private int albumId;
        private int mediaTypeId;
        private int genreId;
        private string composer;
        private double milliseconds;
        private double bytes;
        public TrackInfo() { }
        public TrackInfo(int trackId, string name, int albumId, int mediaTypeId, int genreId, string composer, double milliseconds, double bytes)
        {
            this.TrackId = trackId;
            this.Name = name;
            this.AlbumId = albumId;
            this.MediaTypeId = mediaTypeId;
            this.GenreId = genreId;
            this.Composer = composer;
            this.Milliseconds = milliseconds;
            this.Bytes = bytes;
        }
        public int TrackId
        {
            get => trackId;
            set
            {
                if (trackId == value)
                    return;
                trackId = value;
                PropertyChangedEventHandler eventHandler = this.propertyChanged;
                if (eventHandler != null)
                {
                    eventHandler(this, new PropertyChangedEventArgs(nameof(this.TrackId)));
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                PropertyChangedEventHandler eventHandler = this.propertyChanged;
                if (eventHandler != null)
                {
                    eventHandler(this, new PropertyChangedEventArgs(nameof(this.Name)));
                }
            }
        }
        public int AlbumId
        {
            get => albumId;
            set
            {
                albumId = value;
                PropertyChangedEventHandler eventHandler = this.propertyChanged;
                if (eventHandler != null)
                {
                    eventHandler(this, new PropertyChangedEventArgs(nameof(this.AlbumId)));
                }
            }
        }
        public int MediaTypeId
        {
            get => mediaTypeId;
            set
            {
                mediaTypeId = value;
                PropertyChangedEventHandler eventHandler = this.propertyChanged;
                if (eventHandler != null)
                {
                    eventHandler(this, new PropertyChangedEventArgs(nameof(this.MediaTypeId)));
                }
            }
        }
        public int GenreId
        {
            get => genreId;
            set
            {
                genreId = value;
                PropertyChangedEventHandler eventHandler = this.propertyChanged;
                if (eventHandler != null)
                {
                    eventHandler(this, new PropertyChangedEventArgs(nameof(this.GenreId)));
                }
            }
        }
        public string Composer
        {
            get => composer;
            set
            {
                composer = value;
                PropertyChangedEventHandler eventHandler = this.propertyChanged;
                if (eventHandler != null)
                {
                    eventHandler(this, new PropertyChangedEventArgs(nameof(this.Composer)));
                }
            }
        }
        public double Milliseconds
        {
            get => milliseconds;
            set
            {
                milliseconds = value;
                PropertyChangedEventHandler eventHandler = this.propertyChanged;
                if (eventHandler != null)
                {
                    eventHandler(this, new PropertyChangedEventArgs(nameof(this.Milliseconds)));
                }
            }
        }
        public double Bytes
        {
            get => bytes;
            set
            {
                bytes = value;
                PropertyChangedEventHandler eventHandler = this.propertyChanged;
                if (eventHandler != null)
                {
                    eventHandler(this, new PropertyChangedEventArgs(nameof(this.Bytes)));
                }
            }
        }
        private event PropertyChangedEventHandler propertyChanged;
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { this.propertyChanged += value; }
            remove { this.propertyChanged -= value; }
        }
    }
}
