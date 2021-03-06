﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public abstract partial class TypeSyntax
    {
        public bool IsVar => ((InternalSyntax.TypeSyntax)this.Green).IsVar;

        public bool IsUnmanaged => ((InternalSyntax.TypeSyntax)this.Green).IsUnmanaged;

        public bool IsNotNull => ((InternalSyntax.TypeSyntax)this.Green).IsNotNull;
    }
}
