﻿namespace ViewModel.System.Users
{
    public class RegisterAdminAccountRequest
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
