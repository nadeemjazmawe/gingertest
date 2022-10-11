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

using Amdocs.Ginger.Common;
using GingerCore.Actions;
using System.Windows.Controls;
using GingerWPF.UserControlsLib.UCTreeView;
using Ginger.Drivers.PowerBuilder;
using Amdocs.Ginger.Common.UIElement;

namespace Ginger.WindowExplorer.PowerBuilder
{
    public class PBDatePickerTreeItem : PBControlTreeItemBase, ITreeViewItem, IWindowExplorerTreeItem
    {
        StackPanel ITreeViewItem.Header()
        {
            return TreeViewUtils.CreateItemHeader(UIAElementInfo.ElementTitle, ElementInfo.GetElementTypeImage(eElementType.DatePicker));
        }

        ObservableList<Act> IWindowExplorerTreeItem.GetElementActions()
        {
            ObservableList<Act> list = new ObservableList<Act>();

            list.Add(new ActPBControl()
            {
                Description = "Set DatePicker Value " + UIAElementInfo.ElementTitle,
                ControlAction = ActPBControl.eControlAction.SetValue,
            });

            list.Add(new ActPBControl()
            {
                Description = "Get DatePicker Value " + UIAElementInfo.ElementTitle,
                ControlAction = ActPBControl.eControlAction.GetValue,
            });

            return list;
        }
    }
}
