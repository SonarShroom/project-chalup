using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Raycastandsetup : MonoBehaviour
{
   



    
    //Has the player equiped a weapon
    public bool isWeaponon;
    //Projectile to be shot
    public GameObject bolt;
    //Transform to be used as an instantiation point
    public GameObject shooter;
    //if the bow has been pulled sufficiently to be shot
    [HideInInspector]
    public bool canShoot = false;
  




    private void Update()
    {
     


        if (isWeaponon == true)
        {
          
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
               
                    Instantiate(bolt, shooter.transform.position, shooter.transform.rotation);
                    canShoot = false;
                
                
            }
        }

      



        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;







        if (Physics.Raycast(ray, out hit))
        {
            shooter.transform.LookAt(hit.point);
        
        }else
        {
            shooter.transform.LookAt(Camera.main.transform.forward * 20000    );
        }
                
    
    }
    

    
   
}



