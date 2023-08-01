using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverManager : MonoBehaviour
{
    private bool _hasPackage = false;

    public bool PickupPackage()
    {
        if (_hasPackage)
        {
            Debug.Log("Van is full of packages");
            return false;
        }
        _hasPackage = true;
        return true;
    }

    public bool DeliverPackage()
    {
        if (!_hasPackage)
        {
            Debug.Log("Není co doruèovat");
            return false;
        }
        _hasPackage = false;
        return true;
    }
}
