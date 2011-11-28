﻿using JabbR.Models;

namespace JabbR.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(ChatUser user)
        {
            Name = user.Name;
            Hash = user.Hash;
            Active = user.Status == (int)UserStatus.Active;
        }

        public string Name { get; set; }
        public string Hash { get; set; }
        public bool Active { get; set; }
    }
}