using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    public KartCollider k_collider;
    private TextMeshProUGUI lapText;
    public GameObject countDown;
    public EndGame EndGame;
    public static int lapCount;
    public static string lapDisplay;
    
    void Start(){
        lapText = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        if (countDown.activeSelf == false){
            lapCount = k_collider.getLapCount();
            Debug.Log(lapCount);
            if (lapCount == 0) {
                gameObject.SetActive(false);
                EndGame.setOn(); 
            }
            else if (lapCount == 1) lapDisplay = "Last Lap";
            else if(lapCount == 3) lapDisplay = "2 LAPS TO GO";
            else {
                lapDisplay = lapCount.ToString() + " LAPS TO GO";
            }
            lapText.text = lapDisplay;
        }
        
    }
}
