// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Marketplace.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UsageEventStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UsageEventStatusEnum
    {
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Expired")]
        Expired,
        [EnumMember(Value = "Duplicate")]
        Duplicate,
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "ResourceNotFound")]
        ResourceNotFound,
        [EnumMember(Value = "ResourceNotAuthorized")]
        ResourceNotAuthorized,
        [EnumMember(Value = "InvalidDimension|BadArgument")]
        InvalidDimensionBadArgument
    }
    internal static class UsageEventStatusEnumEnumExtension
    {
        internal static string ToSerializedValue(this UsageEventStatusEnum? value)
        {
            return value == null ? null : ((UsageEventStatusEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UsageEventStatusEnum value)
        {
            switch( value )
            {
                case UsageEventStatusEnum.Accepted:
                    return "Accepted";
                case UsageEventStatusEnum.Expired:
                    return "Expired";
                case UsageEventStatusEnum.Duplicate:
                    return "Duplicate";
                case UsageEventStatusEnum.Error:
                    return "Error";
                case UsageEventStatusEnum.ResourceNotFound:
                    return "ResourceNotFound";
                case UsageEventStatusEnum.ResourceNotAuthorized:
                    return "ResourceNotAuthorized";
                case UsageEventStatusEnum.InvalidDimensionBadArgument:
                    return "InvalidDimension|BadArgument";
            }
            return null;
        }

        internal static UsageEventStatusEnum? ParseUsageEventStatusEnum(this string value)
        {
            switch( value )
            {
                case "Accepted":
                    return UsageEventStatusEnum.Accepted;
                case "Expired":
                    return UsageEventStatusEnum.Expired;
                case "Duplicate":
                    return UsageEventStatusEnum.Duplicate;
                case "Error":
                    return UsageEventStatusEnum.Error;
                case "ResourceNotFound":
                    return UsageEventStatusEnum.ResourceNotFound;
                case "ResourceNotAuthorized":
                    return UsageEventStatusEnum.ResourceNotAuthorized;
                case "InvalidDimension|BadArgument":
                    return UsageEventStatusEnum.InvalidDimensionBadArgument;
            }
            return null;
        }
    }
}
