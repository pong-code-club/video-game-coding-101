using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    //declaring variables
    public int CoinCount;

    public float Health;

    public string PlayerName;

    public bool IsAlive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //declare function
    void Start()
    {
        //assinging value to variables
        CoinCount = 100;
        Health = 500.5f;
        PlayerName = "Jlen";
        IsAlive = true;

        //using variables
        Debug.Log(CoinCount);
        Debug.Log(Health);
        Debug.Log(PlayerName);
        Debug.Log(IsAlive);

        //math operator +,-,*,/
        //logical operator >,<,>=,<=
        //comparison operator ==
     
        Debug.Log(CoinCount + CoinCount);

        //literal values
        //5
        //5.5f
        //true
        //"tall dog"
    }

    // Update is called once per frame
    void Update()
    {
        //CoinCount = CoinCount + 1;

        //calling a function
        //TakeDamage();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,1 * Time.deltaTime,0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -1 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1 * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided With Something");

        //TakeDamage();

        if (collision.gameObject.name == "Boss")
        {
            TakeDamage();
        }

        if (collision.gameObject.name == "Coin")
        {
            //CoinCount = CoinCount + 1;
            CollectCoin();
        }
    }

    //Declaring functions
    void CollectCoin()
    {
        CoinCount = CoinCount + 1;
    }

    void TakeDamage()
    {
        Health = Health - 1;

        if (Health <= 0)
        {
            IsAlive = false;
        }
        else
        {
            //run code here is healt is NOT <= 0
        }

        //conditional statement/if statement
        if (true)
        {
            //run code in here if condition is true
        }
        else
        {
            //otherwise do this
        }
    }
}
