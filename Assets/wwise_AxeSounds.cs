using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wwise_AxeSounds : MonoBehaviour
{
    public AK.Wwise.Bank axeSoundBank;

    private void Awake()
    {
        axeSoundBank.Load();
        AkSoundEngine.RegisterGameObj(gameObject);
    }


    public void Play_WhooshSound()
    {
        AkSoundEngine.PostEvent("Play_AxeWhoosh", gameObject);
    }


    public void Play_StonePunchSound()
    {
        AkSoundEngine.SetSwitch("Axe_Punch_Switch", "Stone", gameObject);
        AkSoundEngine.PostEvent("Play_AxePunch", gameObject);
    }

    public void Play_WoodPunchSound()
    {
        AkSoundEngine.SetSwitch("Axe_Punch_Switch", "Wood", gameObject);
        AkSoundEngine.PostEvent("Play_AxePunch", gameObject);

    }
}