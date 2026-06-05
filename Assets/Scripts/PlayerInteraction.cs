using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactDistance = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E Pressed");

            Ray ray = Camera.main.ScreenPointToRay(
                new Vector3(Screen.width / 2,
                            Screen.height / 2,
                            0));

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactDistance))
            {
                Debug.Log("Hit: " + hit.collider.name);
            }
        }
    }
}