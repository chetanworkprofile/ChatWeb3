﻿namespace ChatWeb3.Models.OutputModels
{
    public class ValidateUsernameModel
    {
        public string username { get; set; } = string.Empty;
        public bool isAvailable { get; set; } = false;
        public string suggestedUsername { get; set; } = string.Empty;

        public ValidateUsernameModel(string username,bool isAvailable, string suggestedUsername)
        {
            this.username = username;
            this.isAvailable = isAvailable;
            this.suggestedUsername = suggestedUsername;
        }
    }
}