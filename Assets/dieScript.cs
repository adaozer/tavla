using UnityEngine;

public class dieScript : MonoBehaviour
{

    public int totalResult;

    public DiceRandom dice1;
    public Dice2Random dice2;

    public int Die1;
    public int Die2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void calculateTotal() {
        dice1.roll();
        dice2.roll();

        Die1 = dice1.rollResult;
        Die2 = dice2.rollResult;

        int total = Die1 + Die2;
        totalResult = total;
        Debug.Log($"Die 1: {Die1}, Die 2: {Die2}, Total: {total}");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
