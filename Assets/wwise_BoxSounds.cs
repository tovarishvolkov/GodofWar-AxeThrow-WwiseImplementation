using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wwise_BoxSounds : MonoBehaviour
{

    float hitVol;

    private void OnCollisionEnter(Collision collision)
    {
        hitVol = collision.relativeVelocity.magnitude;


        AkSoundEngine.PostEvent("Play_boxesDown", gameObject);
    }

    private void Update()
    {
        AkSoundEngine.SetRTPCValue("Box_Crash", hitVol);
    }




}
