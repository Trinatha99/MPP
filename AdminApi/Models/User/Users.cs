﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AdminApi.Models.User
{
    public class Users
    {
		public int UserId { get; set; }
		[Required]
		public int UserRoleId { get; set; }
		[Required]
		[StringLength(100)]
		public string FullName { get; set; }
		[StringLength(100)]
		public string Mobile { get; set; }
		[StringLength(100)]
		public string Email { get; set; }
		public DateTime? DateOfBirth { get; set; }
		[StringLength(500)]
		public string ImagePath { get; set; }
		[Required]
		[StringLength(50)]
		public string UserName { get; set; }
		[Required]
		[StringLength(100)]
		public string Password { get; set; }
		[Required]
		public bool IsActive { get; set; }
		[Required]
		public int AddedBy { get; set; }
		[DefaultValue(false)]
		public bool IsMigrationData { get; set; }
		[Required]
		public DateTime DateAdded { get; set; }
		public DateTime? LastPasswordChangeDate { get; set; }
		public int? PasswordChangedBy { get; set; }
		[Required]
		public bool IsPasswordChange { get; set; }
		public DateTime? LastUpdatedDate { get; set; }
		public int? LastUpdatedBy { get; set; }
		public string UserDesignation { get; set; }
		public string UserReferralId { get; set; }
	}
}
