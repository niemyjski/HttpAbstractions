// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.Framework.Runtime;

namespace Microsoft.AspNet.HttpFeature.Security
{
    [AssemblyNeutral]
    public interface ISignOutContext 
    {
        IList<string> AuthenticationTypes { get; }

        void Accept(string authenticationType, IDictionary<string, object> description);
    }
}