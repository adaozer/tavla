using UnityEngine;

public class Dice2Random : MonoBehaviour
{
    public int rollResult;
    public GameObject parent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void hideKids(int roll) {
        for (int i = 0; i < parent.transform.childCount; i++) {
            GameObject child = parent.transform.GetChild(i).gameObject;
            child.SetActive(i == roll - 1);
        }
    }

    public void roll() {
        int roll = Random.Range(1,7);
        hideKids(roll);
        rollResult = roll;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
