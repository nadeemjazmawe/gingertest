/*
Copyright ? 2014-2018 European Support Limited

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

package com.amdocs.ginger.android;

import android.accessibilityservice.AccessibilityService;
import android.util.Log;
import android.view.accessibility.AccessibilityEvent;

/**
 * Created on 1/1/2017.
 */

public class Recorder extends AccessibilityService{

    @Override
    public void onAccessibilityEvent(AccessibilityEvent event) {

        Log.d("Ginger", "Accessibility event - " + event.toString() );
    }

    @Override
    public void onInterrupt() {
    }
}
