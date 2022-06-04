using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;

public class KartCollider : MonoBehaviour
{
    public KartAgent kartAgent;
    public CheckpointManager _checkpointManager;

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
        if (other.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Finishhh OYYY");
            _checkpointManager.ResetCheckpoints();
        }
    }

    // Saat menempel setelah berbenturan
    // void OnCollisionStay(Collision other)
    // {
    //     if (other.gameObject.CompareTag("Wall"))
    //     {
    //     Debug.Log("MENEMPEL");
    //     kartAgent.AddReward(-0.01f);
    //     }
    // }

    // // Saat melepas setelah berbenturan
    // void OnCollisionExit(Collision other)
    // {
    //     if (other.gameObject.CompareTag("Wall"))
    //     {
    //     Debug.Log("MELEPAS");
    //     kartAgent.AddReward(0.3f);
    //     }
    // }
}