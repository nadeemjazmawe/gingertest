#region License
/*
Copyright © 2014-2022 European Support Limited

Licensed under the Apache License, Version 2.0 (the "License")
you may not use this file except in compliance with the License.
You may obtain a copy of the License at 

http://www.apache.org/licenses/LICENSE-2.0 

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and 
limitations under the License. 
*/
#endregion

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace UIAComWrapperInternal
{
    // It would be nice to do without these, but the AutomationIdentifiers allow you to query for GUIDs, and 
    // so we end up needing them.
    internal static class AutomationIdentifierGuids
    {
        public static readonly Guid AcceleratorKey_Property = new Guid(0x514865df, 0x2557, 0x4cb9, 0xae, 0xed, 0x6c, 0xed, 8, 0x4c, 0xe5, 0x2c);
        public static readonly Guid AccessKey_Property = new Guid(0x6827b12, 0xa7f9, 0x4a15, 0x91, 0x7c, 0xff, 0xa5, 0xad, 0x3e, 0xb0, 0xa7);
        public static readonly Guid AsyncContentLoaded_Event = new Guid(0x5fdee11c, 0xd2fa, 0x4fb9, 0x90, 0x4e, 0x5c, 190, 0xe8, 0x94, 0xd5, 0xef);
        public static readonly Guid AutomationFocusChanged_Event = new Guid(0xb68a1f17, 0xf60d, 0x41a7, 0xa3, 0xcc, 0xb0, 0x52, 0x92, 0x15, 0x5f, 0xe0);
        public static readonly Guid AutomationId_Property = new Guid(0xc82c0500, 0xb60e, 0x4310, 0xa2, 0x67, 0x30, 60, 0x53, 0x1f, 0x8e, 0xe5);
        public static readonly Guid AutomationPropertyChanged_Event = new Guid(0x2527fba1, 0x8d7a, 0x4630, 0xa4, 0xcc, 230, 0x63, 0x15, 0x94, 0x2f, 0x52);
        public static readonly Guid BoundingRectangle_Property = new Guid(0x7bbfe8b2, 0x3bfc, 0x48dd, 0xb7, 0x29, 0xc7, 0x94, 0xb8, 70, 0xe9, 0xa1);
        public static readonly Guid Button_Control = new Guid(0x5a78e369, 0xc6a1, 0x4f33, 0xa9, 0xd7, 0x79, 0xf2, 13, 12, 120, 0x8e);
        public static readonly Guid Calendar_Control = new Guid(0x8913eb88, 0xe5, 0x46bc, 0x8e, 0x4e, 20, 0xa7, 0x86, 0xe1, 0x65, 0xa1);
        public static readonly Guid CheckBox_Control = new Guid(0xfb50f922, 0xa3db, 0x49c0, 0x8b, 0xc3, 6, 0xda, 0xd5, 0x57, 120, 0xe2);
        public static readonly Guid ClassName_Property = new Guid(0x157b7215, 0x894f, 0x4b65, 0x84, 0xe2, 170, 0xc0, 0xda, 8, 0xb1, 0x6b);
        public static readonly Guid ClickablePoint_Property = new Guid(0x196903b, 0xb203, 0x4818, 0xa9, 0xf3, 240, 0x8e, 0x67, 0x5f, 0x23, 0x41);
        public static readonly Guid ComboBox_Control = new Guid(0x54cb426c, 0x2f33, 0x4fff, 170, 0xa1, 0xae, 0xf6, 13, 0xac, 0x5d, 0xeb);
        public static readonly Guid ControlType_Property = new Guid(0xca774fea, 0x28ac, 0x4bc2, 0x94, 0xca, 0xac, 0xec, 0x6d, 0x6c, 0x10, 0xa3);
        public static readonly Guid Culture_Property = new Guid(0xe2d74f27, 0x3d79, 0x4dc2, 0xb8, 0x8b, 0x30, 0x44, 150, 0x3a, 0x8a, 0xfb);
        public static readonly Guid Custom_Control = new Guid(0xf29ea0c3, 0xadb7, 0x430a, 0xba, 0x90, 0xe5, 0x2c, 0x73, 0x13, 230, 0xed);
        public static readonly Guid DataGrid_Control = new Guid(0x84b783af, 0xd103, 0x4b0a, 0x84, 0x15, 0xe7, 0x39, 0x42, 0x41, 15, 0x4b);
        public static readonly Guid DataItem_Control = new Guid(0xa0177842, 0xd94f, 0x42a5, 0x81, 0x4b, 0x60, 0x68, 0xad, 220, 0x8d, 0xa5);
        public static readonly Guid Dock_Pattern = new Guid(0x9cbaa846, 0x83c8, 0x428d, 130, 0x7f, 0x7e, 0x60, 0x63, 0xfe, 6, 0x20);
        public static readonly Guid Dock_Position_Property = new Guid(0x6d67f02e, 0xc0b0, 0x4b10, 0xb5, 0xb9, 0x18, 0xd6, 0xec, 0xf9, 0x87, 0x60);
        public static readonly Guid Document_Control = new Guid(0x3cd6bb6f, 0x6f08, 0x4562, 0xb2, 0x29, 0xe4, 0xe2, 0xfc, 0x7a, 0x9e, 180);
        public static readonly Guid Edit_Control = new Guid(0x6504a5c8, 0x2c86, 0x4f87, 0xae, 0x7b, 0x1a, 0xbd, 220, 0x81, 12, 0xf9);
        public static readonly Guid ExpandCollapse_Pattern = new Guid(0xae05efa2, 0xf9d1, 0x428a, 0x83, 0x4c, 0x53, 0xa5, 0xc5, 0x2f, 0x9b, 0x8b);
        public static readonly Guid ExpandCollapse_State_Property = new Guid(0x275a4c48, 0x85a7, 0x4f69, 0xab, 160, 0xaf, 0x15, 0x76, 0x10, 0, 0x2b);
        public static readonly Guid FrameworkId_Property = new Guid(0xdbfd9900, 0x7e1a, 0x4f58, 0xb6, 0x1b, 0x70, 0x63, 0x12, 15, 0x77, 0x3b);
        public static readonly Guid Grid_ColumnCount_Property = new Guid(0xfe96f375, 0x44aa, 0x4536, 0xac, 0x7a, 0x2a, 0x75, 0xd7, 0x1a, 0x3e, 0xfc);
        public static readonly Guid Grid_Pattern = new Guid(0x260a2ccb, 0x93a8, 0x4e44, 0xa4, 0xc1, 0x3d, 0xf3, 0x97, 0xf2, 0xb0, 0x2b);
        public static readonly Guid Grid_RowCount_Property = new Guid(0x2a9505bf, 0xc2eb, 0x4fb6, 0xb3, 0x56, 130, 0x45, 0xae, 0x53, 0x70, 0x3e);
        public static readonly Guid GridItem_Column_Property = new Guid(0xc774c15c, 0x62c0, 0x4519, 0x8b, 220, 0x47, 190, 0x57, 60, 0x8a, 0xd5);
        public static readonly Guid GridItem_ColumnSpan_Property = new Guid(0x583ea3f5, 0x86d0, 0x4b08, 0xa6, 0xec, 0x2c, 0x54, 0x63, 0xff, 0xc1, 9);
        public static readonly Guid GridItem_Parent_Property = new Guid(0x9d912252, 0xb97f, 0x4ecc, 0x85, 0x10, 0xea, 14, 0x33, 0x42, 0x7c, 0x72);
        public static readonly Guid GridItem_Pattern = new Guid(0xf2d5c877, 0xa462, 0x4957, 0xa2, 0xa5, 0x2c, 150, 0xb3, 3, 0xbc, 0x63);
        public static readonly Guid GridItem_Row_Property = new Guid(0x6223972a, 0xc945, 0x4563, 0x93, 0x29, 0xfd, 0xc9, 0x74, 0xaf, 0x25, 0x53);
        public static readonly Guid GridItem_RowSpan_Property = new Guid(0x4582291c, 0x466b, 0x4e93, 0x8e, 0x83, 0x3d, 0x17, 0x15, 0xec, 12, 0x5e);
        public static readonly Guid Group_Control = new Guid(0xad50aa1c, 0xe8c8, 0x4774, 0xae, 0x1b, 0xdd, 0x86, 0xdf, 11, 0x3b, 220);
        public static readonly Guid HasKeyboardFocus_Property = new Guid(0xcf8afd39, 0x3f46, 0x4800, 150, 0x56, 0xb2, 0xbf, 0x12, 0x52, 0x99, 5);
        public static readonly Guid Header_Control = new Guid(0x5b90cbce, 0x78fb, 0x4614, 130, 0xb6, 0x55, 0x4d, 0x74, 0x71, 0x8e, 0x67);
        public static readonly Guid HeaderItem_Control = new Guid(0xe6bc12cb, 0x7c8e, 0x49cf, 0xb1, 0x68, 0x4a, 0x93, 0xa3, 0x2b, 0xeb, 0xb0);
        public static readonly Guid HelpText_Property = new Guid(0x8555685, 0x977, 0x45c7, 0xa7, 0xa6, 0xab, 0xaf, 0x56, 0x84, 0x12, 0x1a);
        public static readonly Guid Hyperlink_Control = new Guid(0x8a56022c, 0xb00d, 0x4d15, 0x8f, 240, 0x5b, 0x6b, 0x26, 110, 0x5e, 2);
        public static readonly Guid Image_Control = new Guid(0x2d3736e4, 0x6b16, 0x4c57, 0xa9, 0x62, 0xf9, 50, 0x60, 0xa7, 0x52, 0x43);
        public static readonly Guid Invoke_Invoked_Event = new Guid(0xdfd699f0, 0xc915, 0x49dd, 180, 0x22, 0xdd, 0xe7, 0x85, 0xc3, 210, 0x4b);
        public static readonly Guid Invoke_Pattern = new Guid(0xd976c2fc, 0x66ea, 0x4a6e, 0xb2, 0x8f, 0xc2, 0x4c, 0x75, 70, 0xad, 0x37);
        public static readonly Guid IsContentElement_Property = new Guid(0x4bda64a8, 0xf5d8, 0x480b, 0x81, 0x55, 0xef, 0x2e, 0x89, 0xad, 0xb6, 0x72);
        public static readonly Guid IsControlElement_Property = new Guid(0x95f35085, 0xabcc, 0x4afd, 0xa5, 0xf4, 0xdb, 180, 0x6c, 0x23, 15, 0xdb);
        public static readonly Guid IsDockPatternAvailable_Property = new Guid(0x2600a4c4, 0x2ff8, 0x4c96, 0xae, 0x31, 0x8f, 230, 0x19, 0xa1, 60, 0x6c);
        public static readonly Guid IsEnabled_Property = new Guid(0x2109427f, 0xda60, 0x4fed, 0xbf, 0x1b, 0x26, 0x4b, 220, 230, 0xeb, 0x3a);
        public static readonly Guid IsExpandCollapsePatternAvailable_Property = new Guid(0x929d3806, 0x5287, 0x4725, 170, 0x16, 0x22, 0x2a, 0xfc, 0x63, 0xd5, 0x95);
        public static readonly Guid IsGridItemPatternAvailable_Property = new Guid(0x5a43e524, 0xf9a2, 0x4b12, 0x84, 200, 180, 0x8a, 0x3e, 0xfe, 0xdd, 0x34);
        public static readonly Guid IsGridPatternAvailable_Property = new Guid(0x5622c26c, 0xf0ef, 0x4f3b, 0x97, 0xcb, 0x71, 0x4c, 8, 0x68, 0x58, 0x8b);
        public static readonly Guid IsInvokePatternAvailable_Property = new Guid(0x4e725738, 0x8364, 0x4679, 170, 0x6c, 0xf3, 0xf4, 0x19, 0x31, 0xf7, 80);
        public static readonly Guid IsKeyboardFocusable_Property = new Guid(0xf7b8552a, 0x859, 0x4b37, 0xb9, 0xcb, 0x51, 0xe7, 0x20, 0x92, 0xf2, 0x9f);
        public static readonly Guid IsMultipleViewPatternAvailable_Property = new Guid(0xff0a31eb, 0x8e25, 0x469d, 0x8d, 110, 0xe7, 0x71, 0xa2, 0x7c, 0x1b, 0x90);
        public static readonly Guid IsOffscreen_Property = new Guid(0x3c3d160, 0xdb79, 0x42db, 0xa2, 0xef, 0x1c, 0x23, 30, 0xed, 0xe5, 7);
        public static readonly Guid IsPassword_Property = new Guid(0xe8482eb1, 0x687c, 0x497b, 190, 0xbc, 3, 190, 0x53, 0xec, 20, 0x54);
        public static readonly Guid IsRangeValuePatternAvailable_Property = new Guid(0xfda4244a, 0xeb4d, 0x43ff, 0xb5, 0xad, 0xed, 0x36, 0xd3, 0x73, 0xec, 0x4c);
        public static readonly Guid IsRequiredForForm_Property = new Guid(0x4f5f43cf, 0x59fb, 0x4bde, 0xa2, 0x70, 0x60, 0x2e, 0x5e, 0x11, 0x41, 0xe9);
        public static readonly Guid IsScrollItemPatternAvailable_Property = new Guid(0x1cad1a05, 0x927, 0x4b76, 0x97, 0xe1, 15, 0xcd, 0xb2, 9, 0xb9, 0x8a);
        public static readonly Guid IsScrollPatternAvailable_Property = new Guid(0x3ebb7b4a, 0x828a, 0x4b57, 0x9d, 0x22, 0x2f, 0xea, 0x16, 50, 0xed, 13);
        public static readonly Guid IsSelectionItemPatternAvailable_Property = new Guid(0x8becd62d, 0xbc3, 0x4109, 190, 0xe2, 0x8e, 0x67, 0x15, 0x29, 14, 0x68);
        public static readonly Guid IsSelectionPatternAvailable_Property = new Guid(0xf588acbe, 0xc769, 0x4838, 0x9a, 0x60, 0x26, 0x86, 220, 0x11, 0x88, 0xc4);
        public static readonly Guid IsTableItemPatternAvailable_Property = new Guid(0xeb36b40d, 0x8ea4, 0x489b, 160, 0x13, 230, 13, 0x59, 0x51, 0xfe, 0x34);
        public static readonly Guid IsTablePatternAvailable_Property = new Guid(0xcb83575f, 0x45c2, 0x4048, 0x9c, 0x76, 0x15, 0x97, 0x15, 0xa1, 0x39, 0xdf);
        public static readonly Guid IsTextPatternAvailable_Property = new Guid(0xfbe2d69d, 0xaff6, 0x4a45, 130, 0xe2, 0xfc, 0x92, 0xa8, 0x2f, 0x59, 0x17);
        public static readonly Guid IsTogglePatternAvailable_Property = new Guid(0x78686d53, 0xfcd0, 0x4b83, 0x9b, 120, 0x58, 50, 0xce, 0x63, 0xbb, 0x5b);
        public static readonly Guid IsTransformPatternAvailable_Property = new Guid(0xa7f78804, 0xd68b, 0x4077, 0xa5, 0xc6, 0x7a, 0x5e, 0xa1, 0xac, 0x31, 0xc5);
        public static readonly Guid IsValuePatternAvailable_Property = new Guid(0xb5020a7, 0x2119, 0x473b, 190, 0x37, 0x5c, 0xeb, 0x98, 0xbb, 0xfb, 0x22);
        public static readonly Guid IsWindowPatternAvailable_Property = new Guid(0xe7a57bb1, 0x5888, 0x4155, 0x98, 220, 180, 0x22, 0xfd, 0x57, 0xf2, 0xbc);
        public static readonly Guid ItemStatus_Property = new Guid(0x51de0321, 0x3973, 0x43e7, 0x89, 0x13, 11, 8, 0xe8, 0x13, 0xc3, 0x7f);
        public static readonly Guid ItemType_Property = new Guid(0xcdda434d, 0x6222, 0x413b, 0xa6, 0x8a, 50, 0x5d, 0xd1, 0xd4, 15, 0x39);
        public static readonly Guid LabeledBy_Property = new Guid(0xe5b8924b, 0xfc8a, 0x4a35, 0x80, 0x31, 0xcf, 120, 0xac, 0x43, 0xe5, 0x5e);
        public static readonly Guid LayoutInvalidated_Event = new Guid(0xed7d6544, 0xa6bd, 0x4595, 0x9b, 0xae, 0x3d, 40, 0x94, 0x6c, 0xc7, 0x15);
        public static readonly Guid List_Control = new Guid(0x9b149ee1, 0x7cca, 0x4cfc, 0x9a, 0xf1, 0xca, 0xc7, 0xbd, 0xdd, 0x30, 0x31);
        public static readonly Guid ListItem_Control = new Guid(0x7b3717f2, 0x44d1, 0x4a58, 0x98, 0xa8, 0xf1, 0x2a, 0x9b, 0x8f, 120, 0xe2);
        public static readonly Guid LocalizedControlType_Property = new Guid(0x8763404f, 0xa1bd, 0x452a, 0x89, 0xc4, 0x3f, 1, 0xd3, 0x83, 0x38, 6);
        public static readonly Guid Menu_Control = new Guid(0x2e9b1440, 0xea8, 0x41fd, 0xb3, 0x74, 0xc1, 0xea, 0x6f, 80, 60, 0xd1);
        public static readonly Guid MenuBar_Control = new Guid(0xcc384250, 0xe7b, 0x4ae8, 0x95, 0xae, 160, 0x8f, 0x26, 0x1b, 0x52, 0xee);
        public static readonly Guid MenuClosed_Event = new Guid(0x3cf1266e, 0x1582, 0x4041, 0xac, 0xd7, 0x88, 0xa3, 90, 150, 0x52, 0x97);
        public static readonly Guid MenuItem_Control = new Guid(0xf45225d3, 0xd0a0, 0x49d8, 0x98, 0x34, 0x9a, 0, 13, 0x2a, 0xed, 220);
        public static readonly Guid MenuOpened_Event = new Guid(0xebe2e945, 0x66ca, 0x4ed1, 0x9f, 0xf8, 0x2a, 0xd7, 0xdf, 10, 0x1b, 8);
        public static readonly Guid MultipleView_CurrentView_Property = new Guid(0x7a81a67a, 0xb94f, 0x4875, 0x91, 0x8b, 0x65, 200, 210, 0xf9, 0x98, 0xe5);
        public static readonly Guid MultipleView_Pattern = new Guid(0x547a6ae4, 0x113f, 0x47c4, 0x85, 15, 0xdb, 0x4d, 250, 70, 0x6b, 0x1d);
        public static readonly Guid MultipleView_SupportedViews_Property = new Guid(0x8d5db9fd, 0xce3c, 0x4ae7, 0xb7, 0x88, 0x40, 10, 60, 100, 0x55, 0x47);
        public static readonly Guid Name_Property = new Guid(0xc3a6921b, 0x4a99, 0x44f1, 0xbc, 0xa6, 0x61, 0x18, 0x70, 0x52, 0xc4, 0x31);
        public static readonly Guid NewNativeWindowHandle_Property = new Guid(0x5196b33b, 0x380a, 0x4982, 0x95, 0xe1, 0x91, 0xf3, 0xef, 0x60, 0xe0, 0x24);
        public static readonly Guid NotSupported = new Guid(0xdb590eb6, 0x12c1, 0x4d3a, 0xb7, 20, 0x29, 0x11, 0x2b, 0x3a, 0x6d, 0x93);
        public static readonly Guid Orientation_Property = new Guid(0xa01eee62, 0x3884, 0x4415, 0x88, 0x7e, 0x67, 0x8e, 0xc2, 30, 0x39, 0xba);
        public static readonly Guid Pane_Control = new Guid(0x5c2b3f5b, 0x9182, 0x42a3, 0x8d, 0xec, 140, 4, 0xc1, 0xee, 0x63, 0x4d);
        public static readonly Guid ProcessId_Property = new Guid(0x40499998, 0x9c31, 0x4245, 0xa4, 3, 0x87, 50, 14, 0x59, 0xea, 0xf6);
        public static readonly Guid ProgressBar_Control = new Guid(0x228c9f86, 0xc36c, 0x47bb, 0x9f, 0xb6, 0xa5, 0x83, 0x4b, 0xfc, 0x53, 0xa4);
        public static readonly Guid RadioButton_Control = new Guid(0x3bdb49db, 0xfe2c, 0x4483, 0xb3, 0xe1, 0xe5, 0x7f, 0x21, 0x94, 0x40, 0xc6);
        public static readonly Guid RangeValue_IsReadOnly_Property = new Guid(0x25fa1055, 0xdebf, 0x4373, 0xa7, 0x9e, 0x1f, 0x1a, 0x19, 8, 0xd3, 0xc4);
        public static readonly Guid RangeValue_LargeChange_Property = new Guid(0xa1f96325, 0x3a3d, 0x4b44, 0x8e, 0x1f, 0x4a, 70, 0xd9, 0x84, 0x40, 0x19);
        public static readonly Guid RangeValue_Maximum_Property = new Guid(0x19319914, 0xf979, 0x4b35, 0xa1, 0xa6, 0xd3, 0x7e, 5, 0x43, 0x34, 0x73);
        public static readonly Guid RangeValue_Minimum_Property = new Guid(0x78cbd3b2, 0x684d, 0x4860, 0xaf, 0x93, 0xd1, 0xf9, 0x5c, 0xb0, 0x22, 0xfd);
        public static readonly Guid RangeValue_Pattern = new Guid(0x18b00d87, 0xb1c9, 0x476a, 0xbf, 0xbd, 0x5f, 11, 0xdb, 0x92, 0x6f, 0x63);
        public static readonly Guid RangeValue_SmallChange_Property = new Guid(0x81c2c457, 0x3941, 0x4107, 0x99, 0x75, 0x13, 0x97, 0x60, 0xf7, 0xc0, 0x72);
        public static readonly Guid RangeValue_Value_Property = new Guid(0x131f5d98, 0xc50c, 0x489d, 0xab, 0xe5, 0xae, 0x22, 8, 0x98, 0xc5, 0xf7);
        public static readonly Guid RuntimeId_Property = new Guid(0xa39eebfa, 0x7fba, 0x4c89, 180, 0xd4, 0xb9, 0x9e, 0x2d, 0xe7, 0xd1, 0x60);
        public static readonly Guid Scroll_HorizontallyScrollable_Property = new Guid(0x8b925147, 0x28cd, 0x49ae, 0xbd, 0x63, 0xf4, 0x41, 0x18, 210, 0xe7, 0x19);
        public static readonly Guid Scroll_HorizontalScrollPercent_Property = new Guid(0xc7c13c0e, 0xeb21, 0x47ff, 0xac, 0xc4, 0xb5, 0xa3, 0x35, 15, 0x51, 0x91);
        public static readonly Guid Scroll_HorizontalViewSize_Property = new Guid(0x70c2e5d4, 0xfcb0, 0x4713, 0xa9, 170, 0xaf, 0x92, 0xff, 0x79, 0xe4, 0xcd);
        public static readonly Guid Scroll_Pattern = new Guid(0x895fa4b4, 0x759d, 0x4c50, 0x8e, 0x15, 3, 70, 6, 0x72, 0, 60);
        public static readonly Guid Scroll_VerticallyScrollable_Property = new Guid(0x89164798, 0x68, 0x4315, 0xb8, 0x9a, 30, 0x7c, 0xfb, 0xbc, 0x3d, 0xfc);
        public static readonly Guid Scroll_VerticalScrollPercent_Property = new Guid(0x6c8d7099, 0xb2a8, 0x4948, 0xbf, 0xf7, 60, 0xf9, 5, 0x8b, 0xfe, 0xfb);
        public static readonly Guid Scroll_VerticalViewSize_Property = new Guid(0xde6a2e22, 0xd8c7, 0x40c5, 0x83, 0xba, 0xe5, 0xf6, 0x81, 0xd5, 0x31, 8);
        public static readonly Guid ScrollBar_Control = new Guid(0xdaf34b36, 0x5065, 0x4946, 0xb2, 0x2f, 0x92, 0x59, 0x5f, 0xc0, 0x75, 0x1a);
        public static readonly Guid ScrollItem_Pattern = new Guid(0x4591d005, 0xa803, 0x4d5c, 180, 0xd5, 0x8d, 40, 0, 0xf9, 6, 0xa7);
        public static readonly Guid Selection_CanSelectMultiple_Property = new Guid(0x49d73da5, 0xc883, 0x4500, 0x88, 0x3d, 0x8f, 0xcf, 0x8d, 0xaf, 0x6c, 190);
        public static readonly Guid Selection_Invalidated_Event = new Guid(0xcac14904, 0x16b4, 0x4b53, 0x8e, 0x47, 0x4c, 0xb1, 0xdf, 0x26, 0x7b, 0xb7);
        public static readonly Guid Selection_IsSelectionRequired_Property = new Guid(0xb1ae4422, 0x63fe, 0x44e7, 0xa5, 0xa5, 0xa7, 0x38, 200, 0x29, 0xb1, 0x9a);
        public static readonly Guid Selection_Pattern = new Guid(0x66e3b7e8, 0xd821, 0x4d25, 0x87, 0x61, 0x43, 0x5d, 0x2c, 0x8b, 0x25, 0x3f);
        public static readonly Guid Selection_Selection_Property = new Guid(0xaa6dc2a2, 0xe2b, 0x4d38, 150, 0xd5, 0x34, 0xe4, 0x70, 0xb8, 0x18, 0x53);
        public static readonly Guid SelectionItem_ElementAddedToSelection_Event = new Guid(0x3c822dd1, 0xc407, 0x4dba, 0x91, 0xdd, 0x79, 0xd4, 0xae, 0xd0, 0xae, 0xc6);
        public static readonly Guid SelectionItem_ElementRemovedFromSelection_Event = new Guid(0x97fa8a9, 0x7079, 0x41af, 0x8b, 0x9c, 9, 0x34, 0xd8, 0x30, 0x5e, 0x5c);
        public static readonly Guid SelectionItem_ElementSelected_Event = new Guid(0xb9c7dbfb, 0x4ebe, 0x4532, 170, 0xf4, 0, 140, 0xf6, 0x47, 0x23, 60);
        public static readonly Guid SelectionItem_IsSelected_Property = new Guid(0xf122835f, 0xcd5f, 0x43df, 0xb7, 0x9d, 0x4b, 0x84, 0x9e, 0x9e, 0x60, 0x20);
        public static readonly Guid SelectionItem_Pattern = new Guid(0x9bc64eeb, 0x87c7, 0x4b28, 0x94, 0xbb, 0x4d, 0x9f, 0xa4, 0x37, 0xb6, 0xef);
        public static readonly Guid SelectionItem_SelectionContainer_Property = new Guid(0xa4365b6e, 0x9c1e, 0x4b63, 0x8b, 0x53, 0xc2, 0x42, 0x1d, 0xd1, 0xe8, 0xfb);
        public static readonly Guid Separator_Control = new Guid(0x8767eba3, 0x2a63, 0x4ab0, 0xac, 0x8d, 170, 80, 0xe2, 0x3d, 0xe9, 120);
        public static readonly Guid Slider_Control = new Guid(0xb033c24b, 0x3b35, 0x4cea, 0xb6, 9, 0x76, 0x36, 130, 250, 0x66, 11);
        public static readonly Guid Spinner_Control = new Guid(0x60cc4b38, 0x3cb1, 0x4161, 180, 0x42, 0xc6, 0xb7, 0x26, 0xc1, 120, 0x25);
        public static readonly Guid SplitButton_Control = new Guid(0x7011f01f, 0x4ace, 0x4901, 180, 0x61, 0x92, 10, 0x6f, 0x1c, 0xa6, 80);
        public static readonly Guid StatusBar_Control = new Guid(0xd45e7d1b, 0x5873, 0x475f, 0x95, 0xa4, 4, 0x33, 0xe1, 0xf1, 0xb0, 10);
        public static readonly Guid StructureChanged_Event = new Guid(0x59977961, 0x3edd, 0x4b11, 0xb1, 0x3b, 0x67, 0x6b, 0x2a, 0x2a, 0x6c, 0xa9);
        public static readonly Guid Tab_Control = new Guid(0x38cd1f2d, 0x337a, 0x4bd2, 0xa5, 0xe3, 0xad, 180, 0x69, 0xe3, 11, 0xd3);
        public static readonly Guid TabItem_Control = new Guid(0x2c6a634f, 0x921b, 0x4e6e, 0xb2, 110, 8, 0xfc, 0xb0, 0x79, 0x8f, 0x4c);
        public static readonly Guid Table_ColumnHeaders_Property = new Guid(0xaff1d72b, 0x968d, 0x42b1, 180, 0x59, 0x15, 11, 0x29, 0x9d, 0xa6, 100);
        public static readonly Guid Table_Control = new Guid(0x773bfa0e, 0x5bc4, 0x4deb, 0x92, 0x1b, 0xde, 0x7b, 50, 6, 0x22, 0x9e);
        public static readonly Guid Table_Pattern = new Guid(0xc415218e, 0xa028, 0x461e, 170, 0x92, 0x8f, 0x92, 0x5c, 0xf7, 0x93, 0x51);
        public static readonly Guid Table_RowHeaders_Property = new Guid(0xd9e35b87, 0x6eb8, 0x4562, 170, 0xc6, 0xa8, 0xa9, 7, 0x52, 0x36, 0xa8);
        public static readonly Guid Table_RowOrColumnMajor_Property = new Guid(0x83be75c3, 0x29fe, 0x4a30, 0x85, 0xe1, 0x2a, 0x62, 0x77, 0xfd, 0x10, 110);
        public static readonly Guid TableItem_ColumnHeaderItems_Property = new Guid(0x967a56a3, 0x74b6, 0x431e, 0x8d, 230, 0x99, 0xc4, 0x11, 3, 0x1c, 0x58);
        public static readonly Guid TableItem_Pattern = new Guid(0xdf1343bd, 0x1888, 0x4a29, 0xa5, 12, 0xb9, 0x2e, 0x6d, 0xe3, 0x7f, 0x6f);
        public static readonly Guid TableItem_RowHeaderItems_Property = new Guid(0xb3f853a0, 0x574, 0x4cd8, 0xbc, 0xd7, 0xed, 0x59, 0x23, 0x57, 0x2d, 0x97);
        public static readonly Guid Text_AnimationStyle_Attribute = new Guid(0x628209f0, 0x7c9a, 0x4d57, 190, 100, 0x1f, 0x18, 0x36, 0x57, 0x1f, 0xf5);
        public static readonly Guid Text_BackgroundColor_Attribute = new Guid(0xfdc49a07, 0x583d, 0x4f17, 0xad, 0x27, 0x77, 0xfc, 0x83, 0x2a, 60, 11);
        public static readonly Guid Text_BulletStyle_Attribute = new Guid(0xc1097c90, 0xd5c4, 0x4237, 0x97, 0x81, 0x3b, 0xec, 0x8b, 0xa5, 0x4e, 0x48);
        public static readonly Guid Text_CapStyle_Attribute = new Guid(0xfb059c50, 0x92cc, 0x49a5, 0xba, 0x8f, 10, 0xa8, 0x72, 0xbb, 0xa2, 0xf3);
        public static readonly Guid Text_CompositionState_Attribute = new Guid(0x99adceba, 0x5223, 0x47a2, 0xa8, 220, 0x76, 0x7b, 0x6d, 160, 10, 0x8e);
        public static readonly Guid Text_Control = new Guid(0xae9772dc, 0xd331, 0x4f09, 190, 0x20, 0x7e, 0x6d, 250, 240, 0x7b, 10);
        public static readonly Guid Text_Culture_Attribute = new Guid(0xc2025af9, 0xa42d, 0x4ced, 0xa1, 0xfb, 0xc6, 0x74, 0x63, 0x15, 0x22, 0x2e);
        public static readonly Guid Text_FlowDirections_Attribute = new Guid(0x8bdf8739, 0xf420, 0x423e, 0xaf, 0x77, 0x20, 0xa5, 0xd9, 0x73, 0xa9, 7);
        public static readonly Guid Text_FontName_Attribute = new Guid(0x64e63ba8, 0xf2e5, 0x476e, 0xa4, 0x77, 0x17, 0x34, 0xfe, 170, 0xf7, 0x26);
        public static readonly Guid Text_FontSize_Attribute = new Guid(0xdc5eeeff, 0x506, 0x4673, 0x93, 0xf2, 0x37, 0x7e, 0x4a, 0x8e, 1, 0xf1);
        public static readonly Guid Text_FontWeight_Attribute = new Guid(0x6fc02359, 0xb316, 0x4f5f, 180, 1, 0xf1, 0xce, 0x55, 0x74, 0x18, 0x53);
        public static readonly Guid Text_ForegroundColor_Attribute = new Guid(0x72d1c95d, 0x5e60, 0x471a, 150, 0xb1, 0x6c, 0x1b, 0x3b, 0x77, 0xa4, 0x36);
        public static readonly Guid Text_Heading_Attribute = new Guid(0xbb20d631, 0x2aa2, 0x420a, 0xad, 0x4e, 0x7a, 0x26, 0x53, 0xa7, 190, 60);
        public static readonly Guid Text_HeadingLevel_Attribute = new Guid(0x713d7e60, 0xc33b, 0x4c41, 0xbd, 13, 0x86, 12, 0xdb, 0xb1, 0xdb, 0x25);
        public static readonly Guid Text_HorizontalTextAlignment_Attribute = new Guid(0x4ea6161, 0xfba3, 0x477a, 0x95, 0x2a, 0xbb, 50, 0x6d, 2, 0x6a, 0x5b);
        public static readonly Guid Text_IndentationFirstLine_Attribute = new Guid(0x206f9ad5, 0xc1d3, 0x424a, 0x81, 130, 0x6d, 0xa9, 0xa7, 0xf3, 0xd6, 50);
        public static readonly Guid Text_IndentationLeading_Attribute = new Guid(0x5cf66bac, 0x2d45, 0x4a4b, 0xb6, 0xc9, 0xf7, 0x22, 0x1d, 40, 0x15, 0xb0);
        public static readonly Guid Text_IndentationTrailing_Attribute = new Guid(0x97ff6c0f, 0x1ce4, 0x408a, 0xb6, 0x7b, 0x94, 0xd8, 0x3e, 0xb6, 0x9b, 0xf2);
        public static readonly Guid Text_IsHidden_Attribute = new Guid(0x360182fb, 0xbdd7, 0x47f6, 0xab, 0x69, 0x19, 0xe3, 0x3f, 0x8a, 0x33, 0x44);
        public static readonly Guid Text_IsItalic_Attribute = new Guid(0xfce12a56, 0x1336, 0x4a34, 150, 0x63, 0x1b, 0xab, 0x47, 0x23, 0x93, 0x20);
        public static readonly Guid Text_IsReadOnly_Attribute = new Guid(0xa738156b, 0xca3e, 0x495e, 0x95, 20, 0x83, 60, 0x44, 15, 0xeb, 0x11);
        public static readonly Guid Text_IsSubscript_Attribute = new Guid(0xf0ead858, 0x8f53, 0x413c, 0x87, 0x3f, 0x1a, 0x7d, 0x7f, 0x5e, 13, 0xe4);
        public static readonly Guid Text_IsSuperscript_Attribute = new Guid(0xda706ee4, 0xb3aa, 0x4645, 0xa4, 0x1f, 0xcd, 0x25, 0x15, 0x7d, 0xea, 0x76);
        public static readonly Guid Text_MarginBottom_Attribute = new Guid(0x7ee593c4, 0x72b4, 0x4cac, 0x92, 0x71, 0x3e, 210, 0x4b, 14, 0x4d, 0x42);
        public static readonly Guid Text_MarginLeading_Attribute = new Guid(0x9e9242d0, 0x5ed0, 0x4900, 0x8e, 0x8a, 0xee, 0xcc, 3, 0x83, 90, 0xfc);
        public static readonly Guid Text_MarginTop_Attribute = new Guid(0x683d936f, 0xc9b9, 0x4a9a, 0xb3, 0xd9, 210, 13, 0x33, 0x31, 30, 0x2a);
        public static readonly Guid Text_MarginTrailing_Attribute = new Guid(0xaf522f98, 0x999d, 0x40af, 0xa5, 0xb2, 1, 0x69, 0xd0, 0x34, 0x20, 2);
        public static readonly Guid Text_MarkedAutocorrected_Attribute = new Guid(0x7308e1ec, 0x294c, 0x4e39, 0xab, 0x4c, 0x66, 0x27, 13, 0xb9, 0x8d, 0xe2);
        public static readonly Guid Text_MarkedGrammaticallyWrong_Attribute = new Guid(0x258d49f0, 0x7ccd, 0x4365, 0xae, 0x44, 0x8f, 0xd4, 0x42, 0x41, 0xe1, 0xe3);
        public static readonly Guid Text_MarkedMisspelled_Attribute = new Guid(0x55b59213, 0x265c, 0x4234, 0xa6, 0xc2, 0x17, 0x4d, 0xab, 250, 0x6b, 0xd8);
        public static readonly Guid Text_MarkedSmartTag_Attribute = new Guid(0x1c07d3f3, 0xb3e5, 0x4e27, 0xa7, 0xf4, 0xb0, 0x9a, 0x98, 0xea, 0x5e, 0x79);
        public static readonly Guid Text_MixedAttributeValue_Attribute = new Guid(0xcbb9ed73, 0x2350, 0x4abf, 0x9c, 0x24, 140, 0x19, 0xdd, 0x37, 0x12, 0x16);
        public static readonly Guid Text_OrderedListString_Attribute = new Guid(0x8dbe7ed6, 0x8685, 0x4242, 0x84, 0x9c, 0xb1, 0x68, 0xe9, 0xda, 0x53, 0x25);
        public static readonly Guid Text_OutlineStyles_Attribute = new Guid(0x5b675b27, 0xdb89, 0x46fe, 0x97, 12, 0x61, 0x4d, 0x52, 0x3b, 0xb9, 0x7d);
        public static readonly Guid Text_OverlineColor_Attribute = new Guid(0x83ab383a, 0xfd43, 0x40da, 0xab, 0x3e, 0xec, 0xf8, 0x16, 0x5c, 0xbb, 0x6d);
        public static readonly Guid Text_OverlineStyle_Attribute = new Guid(0xa234d66, 0x617e, 0x427f, 0x87, 0x1d, 0xe1, 0xff, 30, 12, 0x21, 0x3f);
        public static readonly Guid Text_PageHeight_Attribute = new Guid(0x67a3be41, 0x9532, 0x46fc, 0xab, 0x93, 0x7a, 230, 0xca, 0xe5, 0x9a, 0xb8);
        public static readonly Guid Text_PageNumber_Attribute = new Guid(0x5cd55ae6, 0xf369, 0x4ae3, 0x9f, 0x38, 0x25, 11, 0xc5, 0xcb, 0x5e, 110);
        public static readonly Guid Text_PageWidth_Attribute = new Guid(0x8fbd3f19, 0x1292, 0x4e88, 0xbc, 0xeb, 0x9c, 0xff, 0xf6, 0xcc, 0x17, 14);
        public static readonly Guid Text_Pattern = new Guid(0x8615f05d, 0x7de5, 0x44fd, 0xa6, 0x79, 0x2c, 0xa4, 180, 0x60, 0x33, 0xa8);
        public static readonly Guid Text_Portrait_Attribute = new Guid(0x9dda5866, 0xe97f, 0x4d7f, 0x89, 7, 0xf6, 0x76, 0xd8, 0x93, 0x88, 0xe5);
        public static readonly Guid Text_StrikethroughColor_Attribute = new Guid(0xbfe15a18, 0x8c41, 0x4c5a, 0x9a, 11, 4, 0xaf, 14, 7, 0xf4, 0x87);
        public static readonly Guid Text_StrikethroughStyle_Attribute = new Guid(0x72913ef1, 0xda00, 0x4f01, 0x89, 0x9c, 0xac, 90, 0x85, 0x77, 0xa3, 7);
        public static readonly Guid Text_Tabs_Attribute = new Guid(0x2e68d00b, 0x92fe, 0x42d8, 0x89, 0x9a, 0xa7, 0x84, 170, 0x44, 0x54, 0xa1);
        public static readonly Guid Text_TextChanged_Event = new Guid(0x4a342082, 0xf483, 0x48c4, 0xac, 0x11, 0xa8, 0x4b, 0x43, 0x5e, 0x2a, 0x84);
        public static readonly Guid Text_TextSelectionChanged_Event = new Guid(0x918edaa1, 0x71b3, 0x49ae, 0x97, 0x41, 0x79, 190, 0xb8, 0xd3, 0x58, 0xf3);
        public static readonly Guid Text_UnderlineColor_Attribute = new Guid(0xbfa12c73, 0xfde2, 0x4473, 0xbf, 100, 0x10, 0x36, 0xd6, 170, 15, 0x45);
        public static readonly Guid Text_UnderlineStyle_Attribute = new Guid(0x5f3b21c0, 0xede4, 0x44bd, 0x9c, 0x36, 0x38, 0x53, 3, 140, 0xbf, 0xeb);
        public static readonly Guid Text_VerticalTextAlignment_Attribute = new Guid(0x60ebfe9, 0x3493, 0x4123, 170, 0xc2, 0x1f, 12, 0x69, 130, 4, 0xf7);
        public static readonly Guid Thumb_Control = new Guid(0x701ca877, 0xe310, 0x4dd6, 0xb6, 0x44, 0x79, 0x7e, 0x4f, 0xae, 0xa2, 0x13);
        public static readonly Guid TitleBar_Control = new Guid(0x98aa55bf, 0x3bb0, 0x4b65, 0x83, 110, 0x2e, 0xa3, 13, 0xbc, 0x17, 0x1f);
        public static readonly Guid Toggle_Pattern = new Guid(0xb419760, 0xe2f4, 0x43ff, 140, 0x5f, 0x94, 0x57, 200, 0x2b, 0x56, 0xe9);
        public static readonly Guid Toggle_State_Property = new Guid(0xb23cdc52, 0x22c2, 0x4c6c, 0x9d, 0xed, 0xf5, 0xc4, 0x22, 0x47, 0x9e, 0xde);
        public static readonly Guid ToolBar_Control = new Guid(0x8f06b751, 0xe182, 0x4e98, 0x88, 0x93, 0x22, 0x84, 0x54, 0x3a, 0x7d, 0xce);
        public static readonly Guid ToolTip_Control = new Guid(0x5ddc6d1, 0x2137, 0x4768, 0x98, 0xea, 0x73, 0xf5, 0x2f, 0x71, 0x34, 0xf3);
        public static readonly Guid ToolTipClosed_Event = new Guid(0x276d71ef, 0x24a9, 0x49b6, 0x8e, 0x97, 0xda, 0x98, 180, 1, 0xbb, 0xcd);
        public static readonly Guid ToolTipOpened_Event = new Guid(0x3f4b97ff, 0x2edc, 0x451d, 0xbc, 0xa4, 0x95, 0xa3, 0x18, 0x8d, 0x5b, 3);
        public static readonly Guid Transform_CanMove_Property = new Guid(0x1b75824d, 0x208b, 0x4fdf, 0xbc, 0xcd, 0xf1, 0xf4, 0xe5, 0x74, 0x1f, 0x4f);
        public static readonly Guid Transform_CanResize_Property = new Guid(0xbb98dca5, 0x4c1a, 0x41d4, 0xa4, 0xf6, 0xeb, 0xc1, 40, 100, 0x41, 0x80);
        public static readonly Guid Transform_CanRotate_Property = new Guid(0x10079b48, 0x3849, 0x476f, 0xac, 150, 0x44, 0xa9, 0x5c, 0x84, 0x40, 0xd9);
        public static readonly Guid Transform_Pattern = new Guid(0x24b46fdb, 0x587e, 0x49f1, 0x9c, 0x4a, 0xd8, 0xe9, 0x8b, 0x66, 0x4b, 0x7b);
        public static readonly Guid Tree_Control = new Guid(0x7561349c, 0xd241, 0x43f4, 0x99, 8, 0xb5, 240, 0x91, 190, 230, 0x11);
        public static readonly Guid TreeItem_Control = new Guid(0x62c9feb9, 0x8ffc, 0x4878, 0xa3, 0xa4, 150, 0xb0, 0x30, 0x31, 0x5c, 0x18);
        public static readonly Guid Value_IsReadOnly_Property = new Guid(0xeb090f30, 0xe24c, 0x4799, 0xa7, 5, 13, 0x24, 0x7b, 0xc0, 0x37, 0xf8);
        public static readonly Guid Value_Pattern = new Guid(0x17faad9e, 0xc877, 0x475b, 0xb9, 0x33, 0x77, 0x33, 0x27, 0x79, 0xb6, 0x37);
        public static readonly Guid Value_Property = new Guid(0xe95f5e64, 0x269f, 0x4a85, 0xba, 0x99, 0x40, 0x92, 0xc3, 0xea, 0x29, 0x86);
        public static readonly Guid Window_CanMaximize_Property = new Guid(0x64fff53f, 0x635d, 0x41c1, 0x95, 12, 0xcb, 90, 0xdf, 190, 40, 0xe3);
        public static readonly Guid Window_CanMinimize_Property = new Guid(0xb73b4625, 0x5988, 0x4b97, 180, 0xc2, 0xa6, 0xfe, 110, 120, 200, 0xc6);
        public static readonly Guid Window_Closed_Event = new Guid(0xedf141f8, 0xfa67, 0x4e22, 0xbb, 0xf7, 0x94, 0x4e, 5, 0x73, 0x5e, 0xe2);
        public static readonly Guid Window_Control = new Guid(0xe13a7242, 0xf462, 0x4f4d, 0xae, 0xc1, 0x53, 0xb2, 0x8d, 0x6c, 50, 0x90);
        public static readonly Guid Window_InteractionState_Property = new Guid(0x4fed26a4, 0x455, 0x4fa2, 0xb2, 0x1c, 0xc4, 0xda, 0x2d, 0xb1, 0xff, 0x9c);
        public static readonly Guid Window_IsModal_Property = new Guid(0xff4e6892, 0x37b9, 0x4fca, 0x85, 50, 0xff, 230, 0x74, 0xec, 0xfe, 0xed);
        public static readonly Guid Window_IsTopmost_Property = new Guid(0xef7d85d3, 0x937, 0x4962, 0x92, 0x41, 0xb6, 0x23, 0x45, 0xf2, 0x40, 0x41);
        public static readonly Guid Window_Opened_Event = new Guid(0xd3e81d06, 0xde45, 0x4f2f, 150, 0x33, 0xde, 0x9e, 2, 0xfb, 0x65, 0xaf);
        public static readonly Guid Window_Pattern = new Guid(0x27901735, 0xc760, 0x4994, 0xad, 0x11, 0x59, 0x19, 230, 6, 0xb1, 0x10);
        public static readonly Guid Window_VisualState_Property = new Guid(0x4ab7905f, 0xe860, 0x453e, 0xa3, 10, 0xf6, 0x43, 30, 0x5d, 170, 0xd5);

        // New identifiers introduced in Windows 7
        public static readonly Guid IsLegacyIAccessiblePatternAvailable_Property = new Guid(0xd8ebd0c7, 0x929a, 0x4ee7, 0x8d, 0x3a, 0xd3, 0xd9, 0x44, 0x13, 0x02, 0x7b);
        public static readonly Guid IsItemContainerPatternAvailable_Property = new Guid(0x624b5ca7, 0xfe40, 0x4957, 0xa0, 0x19, 0x20, 0xc4, 0xcf, 0x11, 0x92, 0x0f);
        public static readonly Guid IsVirtualizedItemPatternAvailable_Property = new Guid(0x302cb151, 0x2ac8, 0x45d6, 0x97, 0x7b, 0xd2, 0xb3, 0xa5, 0xa5, 0x3f, 0x20);
        public static readonly Guid IsSynchronizedInputPatternAvailable_Property = new Guid(0x75d69cc5, 0xd2bf, 0x4943, 0x87, 0x6e, 0xb4, 0x5b, 0x62, 0xa6, 0xcc, 0x66);
        public static readonly Guid LegacyIAccessible_ChildId_Property = new Guid(0x9a191b5d, 0x9ef2, 0x4787, 0xa4, 0x59, 0xdc, 0xde, 0x88, 0x5d, 0xd4, 0xe8);
        public static readonly Guid LegacyIAccessible_Name_Property = new Guid(0xcaeb063d, 0x40ae, 0x4869, 0xaa, 0x5a, 0x1b, 0x8e, 0x5d, 0x66, 0x67, 0x39);
        public static readonly Guid LegacyIAccessible_Value_Property = new Guid(0xb5c5b0b6, 0x8217, 0x4a77, 0x97, 0xa5, 0x19, 0x0a, 0x85, 0xed, 0x01, 0x56);
        public static readonly Guid LegacyIAccessible_Description_Property = new Guid(0x46448418, 0x7d70, 0x4ea9, 0x9d, 0x27, 0xb7, 0xe7, 0x75, 0xcf, 0x2a, 0xd7);
        public static readonly Guid LegacyIAccessible_Role_Property = new Guid(0x6856e59f, 0xcbaf, 0x4e31, 0x93, 0xe8, 0xbc, 0xbf, 0x6f, 0x7e, 0x49, 0x1c);
        public static readonly Guid LegacyIAccessible_State_Property = new Guid(0xdf985854, 0x2281, 0x4340, 0xab, 0x9c, 0xc6, 0x0e, 0x2c, 0x58, 0x03, 0xf6);
        public static readonly Guid LegacyIAccessible_Help_Property = new Guid(0x94402352, 0x161c, 0x4b77, 0xa9, 0x8d, 0xa8, 0x72, 0xcc, 0x33, 0x94, 0x7a);
        public static readonly Guid LegacyIAccessible_KeyboardShortcut_Property = new Guid(0x8f6909ac, 0x00b8, 0x4259, 0xa4, 0x1c, 0x96, 0x62, 0x66, 0xd4, 0x3a, 0x8a);
        public static readonly Guid LegacyIAccessible_Selection_Property = new Guid(0x8aa8b1e0, 0x0891, 0x40cc, 0x8b, 0x06, 0x90, 0xd7, 0xd4, 0x16, 0x62, 0x19);
        public static readonly Guid LegacyIAccessible_DefaultAction_Property = new Guid(0x3b331729, 0xeaad, 0x4502, 0xb8, 0x5f, 0x92, 0x61, 0x56, 0x22, 0x91, 0x3c);
        public static readonly Guid AriaRole_Property = new Guid(0xdd207b95, 0xbe4a, 0x4e0d, 0xb7, 0x27, 0x63, 0xac, 0xe9, 0x4b, 0x69, 0x16);
        public static readonly Guid AriaProperties_Property = new Guid(0x4213678c, 0xe025, 0x4922, 0xbe, 0xb5, 0xe4, 0x3b, 0xa0, 0x8e, 0x62, 0x21);
        public static readonly Guid IsDataValidForForm_Property = new Guid(0x445ac684, 0xc3fc, 0x4dd9, 0xac, 0xf8, 0x84, 0x5a, 0x57, 0x92, 0x96, 0xba);
        public static readonly Guid ControllerFor_Property = new Guid(0x51124c8a, 0xa5d2, 0x4f13, 0x9b, 0xe6, 0x7f, 0xa8, 0xba, 0x9d, 0x3a, 0x90);
        public static readonly Guid DescribedBy_Property = new Guid(0x7c5865b8, 0x9992, 0x40fd, 0x8d, 0xb0, 0x6b, 0xf1, 0xd3, 0x17, 0xf9, 0x98);
        public static readonly Guid FlowsTo_Property = new Guid(0xe4f33d20, 0x559a, 0x47fb, 0xa8, 0x30, 0xf9, 0xcb, 0x4f, 0xf1, 0xa7, 0x0a);
        public static readonly Guid ProviderDescription_Property = new Guid(0xdca5708a, 0xc16b, 0x4cd9, 0xb8, 0x89, 0xbe, 0xb1, 0x6a, 0x80, 0x49, 0x04);

        public static readonly Guid MenuModeStart_Event = new Guid(0x18d7c631, 0x166a, 0x4ac9, 0xae, 0x3b, 0xef, 0x4b, 0x54, 0x20, 0xe6, 0x81);
        public static readonly Guid MenuModeEnd_Event = new Guid(0x9ecd4c9f, 0x80dd, 0x47b8, 0x82, 0x67, 0x5a, 0xec, 0x06, 0xbb, 0x2c, 0xff);
        public static readonly Guid SynchronizedInput_InputReachedTarget_Event = new Guid(0x93ed549a, 0x0549, 0x40f0, 0xbe, 0xdb, 0x28, 0xe4, 0x4f, 0x7d, 0xe2, 0xa3);
        public static readonly Guid SynchronizedInput_InputReachedOtherElement_Event = new Guid(0xed201d8a, 0x4e6c, 0x415e, 0xa8, 0x74, 0x24, 0x60, 0xc9, 0xb6, 0x6b, 0xa8);
        public static readonly Guid SynchronizedInput_InputDiscarded_Event = new Guid(0x7f36c367, 0x7b18, 0x417c, 0x97, 0xe3, 0x9d, 0x58, 0xdd, 0xc9, 0x44, 0xab);

        public static readonly Guid LegacyIAccessible_Pattern = new Guid(0x54cc0a9f, 0x3395, 0x48af, 0xba, 0x8d, 0x73, 0xf8, 0x56, 0x90, 0xf3, 0xe0);
        public static readonly Guid ItemContainer_Pattern = new Guid(0x3d13da0f, 0x8b9a, 0x4a99, 0x85, 0xfa, 0xc5, 0xc9, 0xa6, 0x9f, 0x1e, 0xd4);
        public static readonly Guid VirtualizedItem_Pattern = new Guid(0xf510173e, 0x2e71, 0x45e9, 0xa6, 0xe5, 0x62, 0xf6, 0xed, 0x82, 0x89, 0xd5);
        public static readonly Guid SynchronizedInput_Pattern = new Guid(0x05c288a6, 0xc47b, 0x488b, 0xb6, 0x53, 0x33, 0x97, 0x7a, 0x55, 0x1b, 0x8b);
    }
    
    internal static class UiaCoreIds
    {
        
        internal const int UIA_E_ELEMENTNOTAVAILABLE = -2147220991;
        internal const int UIA_E_ELEMENTNOTENABLED = -2147220992;
        internal const int UIA_E_NOCLICKABLEPOINT = -2147220990;
        internal const int UIA_E_PROXYASSEMBLYNOTLOADED = -2147220989;

        internal enum AutomationIdType
        {
            Property,
            Pattern,
            Event,
            ControlType,
            TextAttribute
        }

        [SuppressUnmanagedCodeSecurity, SecurityCritical, DllImport("UIAutomationCore.dll", EntryPoint = "UiaLookupId", CharSet = CharSet.Unicode)]
        private static extern int RawUiaLookupId(AutomationIdType type, ref Guid guid);

        [SecurityCritical, SecuritySafeCritical]
        internal static int UiaLookupId(AutomationIdType type, ref Guid guid)
        {
            return RawUiaLookupId(type, ref guid);
        }
    }
}
