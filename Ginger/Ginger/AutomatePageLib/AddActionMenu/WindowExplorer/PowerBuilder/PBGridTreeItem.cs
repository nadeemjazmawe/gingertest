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

extern alias UIAComWrapperNetstandard;
using UIAuto = UIAComWrapperNetstandard::System.Windows.Automation;
using Amdocs.Ginger.Common;
using Ginger.WindowExplorer;
using Ginger.WindowExplorer.PowerBuilder;
using GingerCore.Actions;

using System.Windows.Controls;
using GingerWPF.UserControlsLib.UCTreeView;
using Amdocs.Ginger.Common.UIElement;

namespace Ginger.Drivers.PowerBuilder
{
    public class PBGridTreeItem : PBControlTreeItemBase, ITreeViewItem, IWindowExplorerTreeItem
    {
        StackPanel ITreeViewItem.Header()
        {
            return TreeViewUtils.CreateItemHeader(UIAElementInfo.ElementTitle, ElementInfo.GetElementTypeImage(eElementType.Table));
        }

        ObservableList<Act> IWindowExplorerTreeItem.GetElementActions()
        {
            ObservableList<Act> list = new ObservableList<Act>();
          
            list.Add(new ActTableElement()
            {
                Description = "Set table cell" + UIAElementInfo.ElementObject + " Value",
                RunActionOn = ActTableElement.eRunActionOn.OnCellRowNumColNum,
                ControlAction = ActTableElement.eTableAction.SetValue,
                LocateX = "0",
                LocateY = "0"
            });

            list.Add(new ActTableElement()
            {
                Description = "Get Cell Value",
                RunActionOn = ActTableElement.eRunActionOn.OnCellRowNumColNum,
                ControlAction = ActTableElement.eTableAction.GetValue,                
            });
            return list;
        }

        bool ITreeViewItem.IsExpandable()
        {
            return true;
        }

        Page ITreeViewItem.EditPage(Amdocs.Ginger.Common.Context mContext)
        {
            return new DataGridInfoPage((UIAuto.AutomationElement)UIAElementInfo.ElementObject);
        }
    }
}