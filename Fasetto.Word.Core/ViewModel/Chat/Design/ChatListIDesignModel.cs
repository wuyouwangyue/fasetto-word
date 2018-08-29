﻿using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    public class ChatListDesignModel : ChatListViewModel
    {
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        public ChatListDesignModel()
        {
            this.Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "This new chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true,
                },
                new ChatListItemViewModel
                {
                     Name = "Jesse",
                    Initials = "JA",
                    Message = "Hey dude, here are the new icon",
                    ProfilePictureRGB = "fe4503",
                },
                new ChatListItemViewModel
                {
                     Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up. got 192.168.0.1",
                    ProfilePictureRGB = "00d405",
                    IsSelected = true,
                },
                                new ChatListItemViewModel
                {
                     Name = "Luke",
                    Initials = "LM",
                    Message = "This new chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                },
                new ChatListItemViewModel
                {
                     Name = "Jesse",
                    Initials = "JA",
                    Message = "Hey dude, here are the new icon",
                    ProfilePictureRGB = "fe4503",
                },
                new ChatListItemViewModel
                {
                     Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up. got 192.168.0.1",
                    ProfilePictureRGB = "00d405",
                },
                                new ChatListItemViewModel
                {
                     Name = "Luke",
                    Initials = "LM",
                    Message = "This new chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                },
                new ChatListItemViewModel
                {
                     Name = "Jesse",
                    Initials = "JA",
                    Message = "Hey dude, here are the new icon",
                    ProfilePictureRGB = "fe4503",
                },
                new ChatListItemViewModel
                {
                     Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up. got 192.168.0.1",
                    ProfilePictureRGB = "00d405",
                },
            };
        }
    }
}