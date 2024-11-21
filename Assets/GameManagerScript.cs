using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript Instance;

    public checkerScript selectedChecker;
    public collisionScript selectedPoint;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep GameManager persistent across scenes
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance exists
        }
    }

    public void OnCheckerClicked(checkerScript checker)
    {
        selectedChecker = checker;
        Debug.Log($"Checker selected at point {checker.pointIndex}");
    }

    public void OnPointClicked(collisionScript point)
    {
        if (selectedChecker != null)
        {
            MoveCheckerToPoint(selectedChecker, point);
        }
        else
        {
            Debug.Log("No checker selected. Click ignored.");
        }
    }

    private void MoveCheckerToPoint(checkerScript checker, collisionScript point)
    {
        if (point == null)
        {
            Debug.Log("Invalid point. Move action cancelled.");
            return;
        }

        checker.transform.position = point.transform.position; // Update position
        checker.pointIndex = point.pointIndex; // Update checker's logical point index
        Debug.Log($"Checker moved to point {point.pointIndex}");

        selectedChecker = null; // Deselect the checker after moving
    }
}
