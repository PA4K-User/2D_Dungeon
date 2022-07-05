using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[DisallowMultipleComponent]
public class AimWeaponEvent : MonoBehaviour
{
    public event Action<AimWeaponEvent, AimWeaponEventArgs> OnWeaponAim;

    public void CallAimWeaponEvent(AimDirection aimDirection, float aimAngle, float weaponAngle, Vector3 weaponAimDirectionVector)
    {
        OnWeaponAim?.Invoke(this, new AimWeaponEventArgs
        {
            aimdirection = aimDirection,
            aimAngle = aimAngle,
            weaponAimAngle = weaponAngle,
            weaponAimDirectionVector = weaponAimDirectionVector
        });
    }
}

public class AimWeaponEventArgs : EventArgs
{
    public AimDirection aimdirection;
    public float aimAngle;
    public float weaponAimAngle;
    public Vector3 weaponAimDirectionVector;
}
