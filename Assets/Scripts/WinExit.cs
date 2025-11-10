using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinExit : MonoBehaviour
{
    public float timetoexit = 5;
    public TextMeshProUGUI endtime;

    public void Update()
    {
        endtime.text = ((int)timetoexit).ToString();
        timetoexit -= Time.deltaTime;

        if (timetoexit <= 0)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
