using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverManager : MonoBehaviour
{
    private bool _hasPackage = false;
    private PackageTarget _currentPackage;

    public bool PickupPackage(PackageTarget package)
    {
        if (_hasPackage)
        {
            Debug.Log("Van is full of packages");
            return false;
        }
        _hasPackage = true;
        _currentPackage = package;
        return true;
    }

    public bool DeliverPackage()
    {
        if (!_hasPackage)
        {
            Debug.Log("Nen� co doru�ovat");
            return false;
        }
        _hasPackage = false;
        _currentPackage.Respawn();
        _currentPackage = null;
        return true;
    }
}