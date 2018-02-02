using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEXCORE.Common.Data
{
    public enum eSKControlType
    {
        None = 0,
        SKTextBox = 1,
        SKButton = 2,
        SKLabel = 4,
        SKCheckBox = 16,
        SKGrid = 32,
        SKNumericControl = 64,
        SKCodeHelperTextbox = 128,
        SKTreeView = 256,
        SKAutoCompleteCombo = 512,
        SKRadioButton = 1024,
        SKMaskedEditor = 2048,
        SKCalendarPlus = 4096,
        SKLinkTextBox = 8192,
        SKTabControl = 16384,
        SKSearchPanel = 32768,
        SKGridTag = 65536,
        SKGroupBox = 131072,
        SKComboBox = 262144,
        SKCurrencyEditor = 524288,
        SKGroupPanel = 1048576,
        ALL = 2097152
    }
}
