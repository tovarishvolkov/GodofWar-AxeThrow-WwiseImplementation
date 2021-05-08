using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wwise_SoundBanks : MonoBehaviour
{

    public AK.Wwise.Bank boxSoundBank;

    private void Awake()
    {
        boxSoundBank.Load();
    }
}
