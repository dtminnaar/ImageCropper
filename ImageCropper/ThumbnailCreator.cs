using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageCropper
{
    public partial class ThumbnailCreator : Form
    {
        private Point _center;
        private Image _original;
        private FileInfo _file;
        private bool _changed = false;
        private const string THUMBNAIL = ".thumbnail";

        public ThumbnailCreator()
        {
            InitializeComponent();

            pbViewer.AllowDrop = true;
            this.MouseWheel += OnMouseWheel;
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            var delta = e.Delta > 0 ? 1 : e.Delta < 0 ? -1 : 0;
            var newValue = trackSize.Value + (delta * 3);
            trackSize.Value = Math.Min(trackSize.Maximum, Math.Max(trackSize.Minimum, newValue));
        }

        private void OnViewerClick(object sender, EventArgs e)
        {
            if (_original == null) 
                return;

            var m = e as MouseEventArgs;

            //Calculate the position in the image relative to the click on the picture box
            var xPercent = (decimal)m.X / (decimal)pbViewer.Width;
            var yPercent = (decimal)m.Y / (decimal)pbViewer.Height;

            var x2 = xPercent * _original.Width;
            var y2 = yPercent * _original.Height;
            _center = new Point((int)x2, (int)y2);
            UpdateThumbnail();
        }

        private void OnViewerDragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            var fileName = paths.FirstOrDefault();
            LoadFile(fileName);
        }

        private void OnViewerDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void OnTrackBarChange(object sender, EventArgs e)
        {
            UpdateThumbnail();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            SaveThumbnail();
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveThumbnail();
            }
        }

        private void OnLoadClick(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                LoadFile(openFile.FileName);
            }
        }

        private void NotifyClick(object sender, EventArgs e)
        {
            NotifyPanel.Visible = false;
        }

        private void OnTick(object sender, EventArgs e)
        {
            NotifyPanel.Visible = false;
            notifyTimer.Enabled = false;
        }

        private Image LoadFromFile(string filename)
        {
            var bytes = File.ReadAllBytes(filename);
            var image = Image.FromStream(new MemoryStream(bytes));
            return image;
        }

        private void TryLoadThumbnail(string filename)
        {
            var info = new FileInfo(filename);
            var name = info.FullName.Chop(info.Extension);

            if (name.EndsWith(THUMBNAIL))
            {
                if (File.Exists(filename))
                    pbThumbnail.Image = LoadFromFile(filename);
            }
            else
            {
                var thumbnailName = $"{name}{THUMBNAIL}.jpg";
                if (File.Exists(thumbnailName))
                    pbThumbnail.Image = LoadFromFile(thumbnailName);
            }
        }

        private void LoadFile(string filename)
        {
            this.Text = $"Thumbnail Creator";
            pbThumbnail.Image = null;
            pbViewer.Image = null;
            _changed = false;

            _file = new FileInfo(filename);
            var name = _file.Name.Chop(_file.Extension);

            if (name.EndsWith(THUMBNAIL))
            {
                var pattern = _file.Name.Chop(_file.Extension).Chop(THUMBNAIL) + ".*";
                _file = _file.Directory.GetFiles(pattern).OrderBy(x => x.Name.Length).FirstOrDefault();
            }
            if (_file?.Exists == true)
            {
                TryLoadThumbnail(filename);
                this.Text = $"Thumbnail Creator - {_file.Name}";
                Image img = LoadFromFile(_file.FullName);
                _original = (Image)img.Clone();
                pbViewer.Image = img;
            }
        }

        private void UpdateThumbnail()
        {
            if (_original == null || _center == null)
                return;
            _changed = true;

            //100% on slider represents the full width/height of the image
            var size = (int)((decimal)trackSize.Value / 100 * Math.Min(_original.Width, _original.Height) / 2);

            var right = Math.Min(_original.Width, _center.X + size);
            var bottom = Math.Min(_original.Height, _center.Y + size);

            var left = Math.Max(0, right - 2 * size);
            var top = Math.Max(0, bottom - 2 * size);

            var rectangle = new Rectangle(left, top, size * 2, size * 2);
            var bitmap = new Bitmap(_original);
            var crop = bitmap.Clone(rectangle, System.Drawing.Imaging.PixelFormat.DontCare);
            var thumbnail = new Bitmap(crop, new Size(200, 200));

            pbThumbnail.Image = thumbnail;
        }

        private void SaveThumbnail()
        {
            if (_file == null || pbThumbnail.Image == null)
                return;

            _changed = false;

            var newName = $"{_file.FullName.Chop(_file.Extension)}{THUMBNAIL}.jpg";
            pbThumbnail.Image.Save(newName, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.NotifyPanel.Visible = true;
            notifyTimer.Enabled = true;
        }

        private List<string> GetFiles()
        {
            if (_file != null)
            {
                var files = _file.Directory.GetFiles().Where(x => !x.Name.Contains(THUMBNAIL)).Select(x => x.FullName).OrderBy(x => x).ToList();
                return files;
            }
            return new List<string>();
        }
        private void DoNextPrev(bool next)
        {
            if (_file == null)
                return;

            if (_changed)
            {
                var locationInForm = btnLoad.Location;
                var locationOnScreen = this.PointToScreen(locationInForm);

                DialogResult result;
                using (var model = new SaveDialog())
                {
                    model.Location = new Point(locationOnScreen.X, locationOnScreen.Y);
                    result = model.ShowDialog();
                }

                if (result == DialogResult.Cancel)
                    return;

                if (result == DialogResult.Yes)
                    SaveThumbnail();
            }

            var files = GetFiles();
            var index = files.IndexOf(_file.FullName);

            if (next)
            {
                if (index == (files.Count() - 1))
                    index = 0;
                else
                    index++;
            } else
            {
                if (index == 0)
                    index = files.Count() - 1;
                else
                    index--;
            }

            if (index >= 0 && index < files.Count())
            {
                LoadFile(files[index]);
            }
        }
        private void OnNextClick(object sender, EventArgs e)
        {
            DoNextPrev(true);
        }

        private void OnPrevClick(object sender, EventArgs e)
        {
            DoNextPrev(false);
        }
    }
}
