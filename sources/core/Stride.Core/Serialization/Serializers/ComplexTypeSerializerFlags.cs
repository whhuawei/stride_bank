// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
namespace Stride.Core.Serialization.Serializers;

[Flags]
public enum ComplexTypeSerializerFlags
{
    None = 0,
    SerializePublicFields = 1,
    SerializeNonPublicFields = 2,
    SerializeFields = SerializePublicFields | SerializeNonPublicFields,
    SerializePublicProperties = 4,
}
