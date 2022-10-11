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

using Amdocs.Ginger.Common.Enums;
using System.Windows;

namespace GingerWPF.UserControlsLib.UCTreeView
{
   public interface ITreeView
    {
        UCTreeView Tree { get;}

        void AddToolbarTool(string toolImage, string toolTip = "", RoutedEventHandler clickHandler = null, Visibility toolVisibility = System.Windows.Visibility.Visible, object CommandParameter = null);
        void AddToolbarTool(eImageType imageType, string toolTip = "", RoutedEventHandler clickHandler = null, Visibility toolVisibility = System.Windows.Visibility.Visible, object CommandParameter = null);        
    }
}
