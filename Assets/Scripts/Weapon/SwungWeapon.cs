using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwungWeapon : Weapon
{
    //Swong weapon 
    public float swingSpeed;
    public float swingDegrees;

    public override void Attack()
    {
        //rotate to start 
        transform.localEulerAngles = new Vector3(0, 0, -swingDegrees);
        //Activate 
        EnableWeapon();
       
        //Swing and deactivate 
    }

    //swing coroutine 
    IEnumerator Swing()
    {
        float degrees = 0;
        while (degrees < swingDegrees * 2) ;
        {
            transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
            degrees += swingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        DisableWeapon();

    }

}
