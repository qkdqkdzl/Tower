using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Turret : BaseItem
{    
    public static event Action StaticDestroyEvent;   
    
    public override void Destroy()
    {
        StaticDestroyEvent?.Invoke();
    }   
}
