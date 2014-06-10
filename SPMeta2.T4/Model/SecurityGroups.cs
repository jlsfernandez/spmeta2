﻿using System;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

// <auto-generated>
//     This code was generated by SPMeta2 T4 file.
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace SPMeta2.T4.Model
{
    public static class T4SPSecurityGroup
    {
        #region properties

		public static SecurityGroupDefinition InternalUserGroup = new SecurityGroupDefinition
		{
			Name = "Internal User Group",
			Description = "Security group for internal users.",
		};


		public static SecurityGroupDefinition ExternallUserGroup = new SecurityGroupDefinition
		{
			Name = "Externall User Group",
			Description = "",
		};

        #endregion
    }
}