using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int gems = 0;
    public bool hasKey = false;
    public int health = 5;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}