using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{

    bool isMute;

    public GameObject ses_kapal�;

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
        ses_kapal�.SetActive(true);
        ses_kapal�.SetActive(false);

        if(!isMute)
        {
            ses_kapal�.SetActive(false);
        }
        else
        {
            ses_kapal�.SetActive(true);
        }

    }
}