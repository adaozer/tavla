using UnityEngine;

public class collisionScript : MonoBehaviour
{
    public int pointIndex;

    private void OnMouseDown()
    {
        if (GameManagerScript.Instance == null) return;

        Debug.Log($"Board point {pointIndex} clicked.");

        if (GameManagerScript.Instance.selectedChecker != null)
        {
            // Send the point to GameManager for handling
            GameManagerScript.Instance.OnPointClicked(this);
        }
        else
        {
            Debug.Log("No checker selected. Board point action ignored.");
        }
    }
}
