// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
namespace Stride.Core;

/// <summary>
/// When specified on a property or field, a serializer won't be needed for this type (useful if serializer is dynamically or manually registered).
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class DataMemberCustomSerializerAttribute : Attribute;
