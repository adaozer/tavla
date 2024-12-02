using UnityEngine;

public class collisionScript : MonoBehaviour
{
    public int pointIndex;
    public BoxCollider2D m_Collider;

    void Start()
    {
        m_Collider = GetComponent<BoxCollider2D>();
        m_Collider.enabled = false; // Disable colliders initially
    }

    private void OnMouseDown()
    {
        if (GameManagerScript.Instance == null) return;

        Debug.Log($"Board point {pointIndex} clicked.");

        if (GameManagerScript.Instance.selectedChecker != null)
        {
            // Notify GameManager that this point was clicked
            GameManagerScript.Instance.OnPointClicked(this);
        }
        else
        {
            Debug.Log("No checker selected. Board point action ignored.");
        }
    }
}
