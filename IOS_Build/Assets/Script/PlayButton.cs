using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public GameObject Video;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject ButtonDisabled;
    Animator StopButton;

    private void Start()
    {
        StopButton = ButtonDisabled.GetComponent<Animator>();
    }
    public void PlayButtonDown()
    {
        Video.gameObject.SetActive(true);
        Light1.gameObject.SetActive(true);
        Light2.gameObject.SetActive(true);
        StopButton.SetBool("Disabled", true);
    }
}
