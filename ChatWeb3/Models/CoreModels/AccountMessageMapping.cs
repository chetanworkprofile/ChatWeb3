﻿namespace ChatWeb3.Models
{
    public class AccountMessageMapping
    {
        public Guid id { get; set; } = Guid.Empty;
        public string accountAddress { get; set; } = string.Empty;
        public string message { get; set; } = string.Empty;

        public AccountMessageMapping() { }
        public AccountMessageMapping(string accountAddress, string message)
        {
            id = Guid.NewGuid();
            this.accountAddress = accountAddress;
            this.message = message;
        }
    }
}

// this class is  a model to create mapping b/w acc addr and message generated by server for verification while login/signup using metamask