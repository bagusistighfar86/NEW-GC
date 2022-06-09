 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KartController k_controller;
    public GameObject countDown;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(countDown.activeSelf);
        if (countDown.activeSelf == false){
            var steering = -(Input.GetAxis("Horizontal"));
            k_controller.Steer(steering);
            k_controller.AnimateKart(-steering);

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
                k_controller.ApplyAcceleration(1f);
            }
            else {
                k_controller.ApplyAcceleration(0f);
            }
        }
        
    }
}