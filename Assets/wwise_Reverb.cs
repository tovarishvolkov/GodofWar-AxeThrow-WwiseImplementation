using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wwise_Reverb : MonoBehaviour
{

    public AK.Wwise.AuxBus aux;


    // Start is called before the first frame update
    void Start()
    {
        aux.Validate();
    }

    private void OnTriggerEnter(Collider other)
    {
        aux.IsValid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
