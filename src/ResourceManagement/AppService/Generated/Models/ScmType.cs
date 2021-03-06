// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ScmType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ScmType>))]
    public class ScmType : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ScmType>
    {
        public static readonly ScmType None = Parse("None");
        public static readonly ScmType Dropbox = Parse("Dropbox");
        public static readonly ScmType Tfs = Parse("Tfs");
        public static readonly ScmType LocalGit = Parse("LocalGit");
        public static readonly ScmType GitHub = Parse("GitHub");
        public static readonly ScmType CodePlexGit = Parse("CodePlexGit");
        public static readonly ScmType CodePlexHg = Parse("CodePlexHg");
        public static readonly ScmType BitbucketGit = Parse("BitbucketGit");
        public static readonly ScmType BitbucketHg = Parse("BitbucketHg");
        public static readonly ScmType ExternalGit = Parse("ExternalGit");
        public static readonly ScmType ExternalHg = Parse("ExternalHg");
        public static readonly ScmType OneDrive = Parse("OneDrive");
        public static readonly ScmType VSO = Parse("VSO");
    }
}
