using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverManager : MonoBehaviour
{
    [SerializeField] private Transform _packageIndicator;
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
        _packageIndicator.gameObject.SetActive(true);
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
        _packageIndicator.gameObject.SetActive(false);
        _currentPackage.Respawn();
        _currentPackage = null;
        return true;
    }
}
