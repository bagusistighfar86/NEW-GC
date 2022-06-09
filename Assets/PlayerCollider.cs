using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public CheckpointManager _checkpointManager;
    public int lapCount = 3;
    // Saat mulai berbenturan

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(lapCount);
        if (other.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Finishhh OYYY");
            lapCount--;
            // Debug.Log(lapCount);
            _checkpointManager.ResetCheckpoints();
        }
    }

    public int getLapCount(){
        return lapCount;
    }
}
