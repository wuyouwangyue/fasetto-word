using GalaSoft.MvvmLight;

namespace Fasetto.Word
{
    public class ChatListItemViewModel : ViewModelBase
    {
        /// <summary>
        /// 发送消息的用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 发送消息用户名缩写
        /// </summary>
        public string Initials { get; set; }
        
        /// <summary>
        /// 左侧名字缩写的背景色，值类似于 FFFAAA
        /// </summary>
        public string ProfilePictureRGB { get; set; }

        /// <summary>
        /// 是否有新消息
        /// </summary>
        public bool NewContentAvailable { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
