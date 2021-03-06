﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAVN.Service.AdminAPI.Models.Admins
{
    /// <summary>
    /// Represents request to update admin permissions.
    /// </summary>
    public class AdminUpdatePermissionsModel
    {
        /// <summary>
        /// Admin user id
        /// </summary>
        [Required]
        public Guid AdminUserId { get; set; }

        /// <summary>
        /// A list of permissions for admin.
        /// </summary>
        public List<AdminPermission> Permissions { set; get; }
    }
}
