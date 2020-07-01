
using System;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class BounceController :BoundElement
{

    public void OnNotification(string p_event_path, UnityEngine.Object p_target, object[] p_data)
    {
        switch (p_event_path)
        {
            case BounceNotification.BallHitGround:
                app.model.bounces++;
                Debug.Log("Bounce "+app.model.bounces);
                if (app.model.bounces >= app.model.winCondition)
                {
                    app.view.ball.enabled = false;
                    app.view.ball.GetComponent<Rigidbody>().isKinematic = true; 
                    app.Notify(BounceNotification.GameComplete, this);
                }
                break;

            case BounceNotification.GameComplete:
                Debug.Log("Victory!!");
                break;
        }
    }
}