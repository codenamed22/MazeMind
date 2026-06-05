using UnityEngine;

public class DoorInteractable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance.hasKey)
            {
                Debug.Log("Door Opened!");
            }
            else
            {
                Debug.Log("Need a Key!");
            }
        }
    }
}