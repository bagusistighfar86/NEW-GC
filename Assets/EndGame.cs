using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void setOn(){
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
