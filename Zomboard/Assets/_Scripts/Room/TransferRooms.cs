using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferRooms : MonoBehaviour
{
    public string TargetScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Changing to " + TargetScene);
            SceneManager.LoadScene(TargetScene);
        }
    }
}
