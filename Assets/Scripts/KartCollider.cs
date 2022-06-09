using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;

public class KartCollider : MonoBehaviour
{
    public KartAgent kartAgent;
    public CheckpointManager _checkpointManager;
    private int lapCount = 3;
    // Saat mulai berbenturan
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("TABRAK");
            kartAgent.AddReward(-0.1f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(lapCount);
        if (other.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Finishhh OYYY");
            lapCount--;
            _checkpointManager.ResetCheckpoints();
        }
    }

    public int getLapCount() {
        return lapCount;
    }
}