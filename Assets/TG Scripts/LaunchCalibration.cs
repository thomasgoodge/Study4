using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Threading.Tasks;

public class LaunchCalibration : MonoBehaviour
{
#if WINDOWS_UWP    
    string uriToLaunch = @"ms-hololenssetup://EyeTracking"; //Dynamics365guides URI


    async void LaunchEyeTracking()
    {
            System.Uri uri = new System.Uri(uriToLaunch);

        await Windows.System.Launcher.LaunchUriAsync(uri);
    }
    /*
    await Windows.System.Launcher.LaunchUriAsync(uri);
        #if WINDOWS_UWP
            UnityEngine.WSA.Application.InvokeOnUIThread(async () =>
            {
                bool result = await global::Windows.System.Launcher.LaunchUriAsync(new System.Uri("ms-hololenssetup://EyeTracking"));
                if (!result)
                {
                    Debug.LogError("Launching URI failed to launch.");
                }
            }, false);
            #else
                Debug.LogError("Launching eye tracking not supported Windows UWP");
            #endif
            */
 #endif
}
