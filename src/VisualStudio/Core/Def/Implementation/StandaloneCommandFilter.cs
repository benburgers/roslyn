﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Text.Editor;

namespace Microsoft.VisualStudio.LanguageServices.Implementation;

/// <summary>
/// A CommandFilter used for "normal" files, as opposed to Venus files which are special.
/// </summary>
internal sealed class StandaloneCommandFilter(
    IWpfTextView wpfTextView, IComponentModel componentModel) : AbstractVsTextViewFilter(wpfTextView, componentModel);
