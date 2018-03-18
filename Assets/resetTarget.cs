/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;

public class resetTarget : MonoBehaviour
{
    

    public void resetTracking()
    {
        TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
        TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
        Debug.Log("Reset");
    }

}
