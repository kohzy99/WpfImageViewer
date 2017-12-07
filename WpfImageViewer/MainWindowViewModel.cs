using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WpfImageViewer.Common;

namespace WpfImageViewer
{
    /// <summary>
    /// MainWindowのビューモデルクラス
    /// </summary>
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region コンストラクタ
        public MainWindowViewModel()
        {
            // OnPropertyChangedでnullチェックをしなくてもいいように。
            PropertyChanged += (sender, e) => { };
        }
        #endregion

        #region INotifyPropertyChanged メンバ
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region プロパティ
        private IList<ImageInfo> image;
        /// <summary>
        /// ビューアで表示する画像の情報を取得または設定します。
        /// </summary>
        public IList<ImageInfo> Images
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged(nameof(Images));
            }
        }

        #endregion
    }
}
