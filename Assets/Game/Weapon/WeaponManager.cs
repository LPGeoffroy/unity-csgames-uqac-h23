using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private GameObject primaryWeapon;
    [SerializeField] private GameObject secondaryWeapon;
    // Start is called before the first frame update
    void Start()
    {
        secondaryWeapon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            ToggleWeapon();
        }
    }

    void ToggleWeapon() 
    {
        if(primaryWeapon.gameObject.activeSelf)
        {
            secondaryWeapon.gameObject.SetActive(true);
            primaryWeapon.gameObject.SetActive(false);
        }
        else
        {
            secondaryWeapon.gameObject.SetActive(false);
            primaryWeapon.gameObject.SetActive(true);
        }
    }
}
