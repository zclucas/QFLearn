using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Event<T> where T:Event<T>
{
    // Start is called before the first frame update
    public static Action mOnEvent;

    public static void Register(Action action)
    {
        mOnEvent += action;
    }
    public static void UnRegister(Action action)
    {
        mOnEvent -= action;
    }
    public static void OnTrigger()
    {
        mOnEvent?.Invoke();
    }
}
