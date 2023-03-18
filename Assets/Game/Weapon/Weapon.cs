using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public float shotForce = 10f;
    public Transform muzzle;
    public int magazineSize = 5;

    private int magazine;

    // Start is called before the first frame update
    void Start()
    {
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
        }
        if (Input.GetMouseButtonDown(1))
        {
            magazine = magazineSize;
        }
    }
}
