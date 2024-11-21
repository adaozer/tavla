using UnityEngine;

public class checkerScript : MonoBehaviour
{
    public int pointIndex;

    private void OnMouseDown()
    {
        if (GameManagerScript.Instance == null) return;

        Debug.Log($"Checker at point {pointIndex} clicked.");

        if (GameManagerScript.Instance.selectedChecker == null)
        {
            // Send the checker to GameManager for handling
            GameManagerScript.Instance.OnCheckerClicked(this);
        }
        else
        {
            Debug.Log("Another checker is already selected. Click ignored.");
        }
    }
}
