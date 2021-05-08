using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

    public bool activated;

    public float rotationSpeed;

    wwise_AxeSounds axeSounds;

    private void Start()
    {
        axeSounds = GetComponent<wwise_AxeSounds>();
    }

    void Update()
    {

        if (activated)
        {
            transform.localEulerAngles += Vector3.forward * rotationSpeed * Time.deltaTime;
            axeSounds.Play_WhooshSound();
           
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 11)
        {
            print(collision.gameObject.name);
            GetComponent<Rigidbody>().Sleep();
            GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            GetComponent<Rigidbody>().isKinematic = true;
            activated = false;
            axeSounds.Play_StonePunchSound();
            
           
           
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Breakable"))
        {
            if(other.GetComponent<BreakBoxScript>() != null)
            {
                other.GetComponent<BreakBoxScript>().Break();
                axeSounds.Play_WoodPunchSound();
                


            }
        }
    }
}
