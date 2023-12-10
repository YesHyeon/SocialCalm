using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPageButton : MonoBehaviour
{
    public AudioSource ClickSound;
    public GameObject Page;
    public GameObject NextPage;
    // Start is called before the first frame update
    public void OnButtonClick()
    {
        ClickSound.Play(); // ���� ���
        Page.SetActive(false);
        NextPage.SetActive(true);
    }
}
