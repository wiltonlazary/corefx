// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.Serialization
{
    internal enum SerializationMode
    {
        SharedContract,
#if uapaot
        SharedType
#endif
    }
}
