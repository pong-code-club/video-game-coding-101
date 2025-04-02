using Unity.VisualScripting;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public int CoinCount;
    public float Speed;
    public string PlayerName;
    public bool IsAlive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CoinCount = 10;
        Speed = 7.5f;
        PlayerName = "Thorbog";
        IsAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Greeting()
    {
        Debug.Log("Hello");
    }

    public int GetRandomWholeNumber()
    {
        return Random.Range(0, 100);
    }

    public int AddTwoWholeNumbers(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
