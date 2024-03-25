using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaivour : MonoBehaviour
{
   public Transform weaponAttachmentPoint; // Assign this in the inspector
    public GameObject weaponPrefab; // Assign the prefab of the weapon in the inspector

    void Start()
    {
        EquipWeapon();
    }

    void EquipWeapon()
    {
        if (weaponPrefab != null)
        {
            GameObject weapon = Instantiate(weaponPrefab, weaponAttachmentPoint.position, weaponAttachmentPoint.rotation);
            weapon.transform.parent = weaponAttachmentPoint;
        }
    }
}
