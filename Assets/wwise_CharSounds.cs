using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wwise_CharSounds : MonoBehaviour
{

    public AK.Wwise.Bank charSoundBank;

    public Transform axePosition;


    private void Awake()
    {
        charSoundBank.Load();
    }

    private void Update()
    {
        Vector3 direction = axePosition.transform.position - transform.position;
        RaycastHit outInfo;

        bool hit = Physics.Raycast(transform.position, direction, out outInfo);
        Debug.DrawRay(transform.position, direction);

        AkSoundEngine.SetRTPCValue("Axe_Distance", outInfo.distance);
    }


    public void Play_Move()
    {
        AkSoundEngine.PostEvent("Play_Move", gameObject);

    }

    public void Play_Pull()
    {
        AkSoundEngine.PostEvent("Play_Pull", gameObject);
    }

    public void Play_Throw()
    {
        AkSoundEngine.PostEvent("Play_Throw", gameObject);
        AkSoundEngine.PostEvent("Play_ThrowVoice", gameObject);
    }

    public void Play_Grab()
    {
        AkSoundEngine.PostEvent("Play_Grab", gameObject);
        AkSoundEngine.PostEvent("Stop_Revers_Axe", gameObject);
    }

    public void Play_Revers_Axe()
    {
        AkSoundEngine.PostEvent("Play_Revers_Axe", gameObject);
    }

}
