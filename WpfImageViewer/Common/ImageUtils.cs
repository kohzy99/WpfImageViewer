using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfImageViewer.Common
{
    /// <summary>
    /// 画像ビューアの便利メソッド集
    /// </summary>
    public static class ImageUtils
    {
        /// <summary>
        /// 指定したフォルダから、指定した拡張子のファイルをImageInfo型のリストにして返す。
        /// </summary>
        /// <param name="directory">ファイルを探すディレクトリへのパス</param>
        /// <param name="supportExts">探す拡張子</param>
        /// <returns>引数で指定した条件に合致する画像の情報</returns>
        public static IList<ImageInfo> GetImages(string directory,string[] supportExts)
        {
            if (!Directory.Exists(directory))
            {
                // ディレクトリが無い時は空のリストを返す
                return new List<ImageInfo>();
            }

            var dirInfo = new DirectoryInfo(directory);
            var result = dirInfo.GetFiles()
                .Where(file => supportExts.Contains(file.Extension))
                .Select(file => new ImageInfo { Path = file.FullName })
                .ToList();
            return result;
        }
    }

    /// <summary>
    /// 画像に関する情報を持たせるクラス
    /// </summary>
    public class ImageInfo
    {
        /// <summary>
        /// 画像ファイルへのパス
        /// </summary>
        public string Path { get; set; }
    }
}
