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

using GingerWPF.WizardLib;
using System.Windows;
using System.Windows.Controls;

namespace Ginger.Agents.AddAgentWizardLib
{
    /// <summary>
    /// Interaction logic for AddAgentDriverConfigPage.xaml
    /// </summary>
    public partial class AddAgentDriverConfigPage : Page, IWizardPage
    {
        AddAgentWizard mWizard;

        public AddAgentDriverConfigPage()
        {
            InitializeComponent();
        }

        public void WizardEvent(WizardEventArgs WizardEventArgs)
        {
            switch (WizardEventArgs.EventType)
            {
                case EventType.Init:
                    mWizard = ((AddAgentWizard)WizardEventArgs.Wizard);        
                    break;

                case EventType.Active:
                    AgentDriverConfigPage p = new AgentDriverConfigPage(mWizard.Agent);
                    xDriverConfigFrame.SetContent(p);
                    break;
            }             
        }

        private void xTestBtn_Click(object sender, RoutedEventArgs e)
        {
            xTestBtn.IsEnabled = false;
            try
            {
                mWizard.Agent.AgentOperations.Test();
            }
            finally
            {
                xTestBtn.IsEnabled = true;
            }
        }        
    }
}
