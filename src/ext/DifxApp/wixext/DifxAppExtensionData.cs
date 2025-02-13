// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.DifxApp
{
    using WixToolset.Data;
    using WixToolset.Extensibility;

    public sealed class DifxAppExtensionData : BaseExtensionData
    {
        public override string DefaultCulture => "en-US";

        public override bool TryGetSymbolDefinitionByName(string name, out IntermediateSymbolDefinition symbolDefinition)
        {
            symbolDefinition = DifxAppSymbolDefinitions.ByName(name);
            return symbolDefinition != null;
        }
    }
}
