using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{

    bool isMute;

    public GameObject ses_kapalý;

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
        ses_kapalý.SetActive(true);
        ses_kapalý.SetActive(false);

        if(!isMute)
        {
            ses_kapalý.SetActive(false);
        }
        else
        {
            ses_kapalý.SetActive(true);
        }

    }
}