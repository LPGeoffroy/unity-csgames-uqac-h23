using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float shotForce = 10f;
    [SerializeField] private Transform muzzle;
    [SerializeField] private int magazineSize = 5;
    [SerializeField] private GameObject UI;

    private int magazine;

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
        magazine = magazineSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(magazine > 0)
            {
                GameObject shot = (GameObject)Instantiate(bullet, muzzle.transform.position, muzzle.transform.rotation);
                shot.GetComponent<Rigidbody>().velocity = muzzle.forward * shotForce;

                magazine = magazine -1;
            }
            else
            {
                UI.SetActive(true);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Reload();
        }
    }

    void Reload()
    {
        magazine = magazineSize;
        UI.SetActive(false);
    }
}
