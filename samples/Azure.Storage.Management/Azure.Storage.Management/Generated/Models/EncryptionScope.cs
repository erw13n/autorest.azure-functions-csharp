// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Management.Models
{
    /// <summary> The Encryption Scope resource. </summary>
    public partial class EncryptionScope : Resource
    {
        /// <summary> The provider for the encryption scope. Possible values (case-insensitive):  Microsoft.Storage, Microsoft.KeyVault. </summary>
        public EncryptionScopeSource? Source { get; set; }
        /// <summary> The state of the encryption scope. Possible values (case-insensitive):  Enabled, Disabled. </summary>
        public EncryptionScopeState? State { get; set; }
        /// <summary> Gets the creation date and time of the encryption scope in UTC. </summary>
        public DateTimeOffset? CreationTime { get; internal set; }
        /// <summary> Gets the last modification date and time of the encryption scope in UTC. </summary>
        public DateTimeOffset? LastModifiedTime { get; internal set; }
        /// <summary> The key vault properties for the encryption scope. This is a required field if encryption scope &apos;source&apos; attribute is set to &apos;Microsoft.KeyVault&apos;. </summary>
        public EncryptionScopeKeyVaultProperties KeyVaultProperties { get; set; }
    }
}
