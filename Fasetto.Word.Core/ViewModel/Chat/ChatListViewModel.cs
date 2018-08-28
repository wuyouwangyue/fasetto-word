using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    public class ChatListViewModel : ViewModelBase
    {
        public List<ChatListItemViewModel> Items { get; set; }
    }
}
