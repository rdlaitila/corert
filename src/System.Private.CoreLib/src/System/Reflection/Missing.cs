// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System.Reflection
{
    [Serializable]
    public sealed class Missing : ISerializable
    {
        private Missing() { }
        public static readonly Missing Value = new Missing();

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));
    
            UnitySerializationHolder.GetUnitySerializationInfo(info, this);
        }
    }
}
