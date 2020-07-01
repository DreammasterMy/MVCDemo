using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoundElement : MonoBehaviour { 
    public BounceApplication app {
        get { return GameObject.FindObjectOfType<BounceApplication>(); }
    }
}
public class BounceApplication : MonoBehaviour {

    public BounceModel model;
    public BounceView view;
    public BounceController[] controllers;

    public void Notify(string p_event_path, UnityEngine.Object p_target, params object[] p_data)
    {
        BounceController[] controller_list = GetAllControllers();
        foreach (BounceController c in controller_list)
        {
            c.OnNotification(p_event_path, p_target, p_data);
        }
    }

    public BounceController[] GetAllControllers()
    {
        return controllers;
    }
}
