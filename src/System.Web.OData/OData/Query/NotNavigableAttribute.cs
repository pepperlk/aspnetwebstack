﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;

namespace System.Web.Http.OData.Query
{
    /// <summary>
    /// Represents an <see cref="Attribute"/> that can be placed on a property to specify that the property cannot be navigated in OData query.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NotNavigableAttribute : Attribute
    {
    }
}
