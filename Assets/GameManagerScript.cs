using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript Instance;

    public GameObject selectedChecker;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void OnCheckerClicked(GameObject checker)
    {
        selectedChecker = checker;
        Debug.Log($"Selected checker: {checker.name}");

        // Enable colliders on all board points
        foreach (collisionScript point in FindObjectsOfType<collisionScript>())
        {
            point.m_Collider.enabled = true;
        }
    }

    public void OnPointClicked(collisionScript point)
    {
        if (selectedChecker != null)
        {
            Debug.Log($"Moving checker {selectedChecker.name} to point {point.name}");

            // Move the checker to the selected board point
            selectedChecker.transform.position = point.transform.position;

            // Reset the game state
            selectedChecker = null;

            // Disable all board point colliders
            foreach (collisionScript p in FindObjectsOfType<collisionScript>())
            {
                p.m_Collider.enabled = false;
            }
        }
    }
}
