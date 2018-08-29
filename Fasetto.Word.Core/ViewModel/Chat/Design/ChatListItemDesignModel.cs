namespace Fasetto.Word.Core
{
    public class ChatListItemDesignModel : ChatListItemViewModel
    {

        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();



        public ChatListItemDesignModel()
        {
            this.Name = "Luke";
            this.Initials = "LM";
            this.Message = "This new chat app is awesome! I bet it will be fast too";
            this.ProfilePictureRGB = "3099c5";
            this.NewContentAvailable = true;
            this.IsSelected = true;
        }
    }
}
