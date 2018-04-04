using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ResetTracking : MonoBehaviour {

    private void Start()
    {
        PauseVuforia(false); // So to be sure when app starts, recognition will work.
    }

    public void PauseVuforia(bool what)
    {
        Tracker objectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>() as ObjectTracker;
        if (objectTracker != null)
        {
            if (what)
            {
                objectTracker.Stop();
                Debug.Log("Recognition Stopped");
                CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
                objectTracker.Start();
                Debug.Log("Recognition Started");
            }
        }
    }
}
