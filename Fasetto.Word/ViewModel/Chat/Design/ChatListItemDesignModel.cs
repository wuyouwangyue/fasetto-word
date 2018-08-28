namespace Fasetto.Word
{
    public class ChatListItemDesignModel : ChatListItemViewModel
    {

        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();



        public ChatListItemDesignModel()
        {
            Name = "Luke";
            Initials = "LM";
            Message = "This new chat app is awesome! I bet it will be fast too";
            ProfilePictureRGB = "3099c5";
            NewContentAvailable = true;
            IsSelected = true;
        }
    }
}
