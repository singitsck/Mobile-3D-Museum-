using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopButton : MonoBehaviour
{
    public GameObject Video;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject ButtonDisabled;
    Animator PlayButton;

    private void Start()
    {
        PlayButton = ButtonDisabled.GetComponent<Animator>();
    }
    public void StopButtonDown()
    {
        Video.gameObject.SetActive(false);
        Light1.gameObject.SetActive(false);
        Light2.gameObject.SetActive(false);
        PlayButton.SetBool("Disabled", true);
    }
}
