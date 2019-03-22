using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketplaceActions : MonoBehaviour
{
    public Vector3 animalArea1;
    public Vector3 animalArea2;
    public Vector3 cropArea;
    // Whether the Google Cardboard user is gazing at this button.
    private bool isLookedAt = false;
    // Count time the player has been gazing at the button.
    private float lookTimer = 0f;
    // How long the user can gaze at this before the button is clicked.
    public float timerDuration = 3f;
    private bool clicked;
    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        // While player is looking at this button.
        if (isLookedAt)
        {

            // Increment the gaze timer.
            lookTimer += Time.deltaTime;


            // Gaze time exceeded limit - button is considered clicked.
            if (lookTimer > timerDuration)
            {

                if (clicked == false)
                {
                    Debug.Log("clicked on this object");
                    GetComponent<Button>().onClick.Invoke();
                    clicked = true;
                }
            }
        }

        // Not gazing at this anymore, reset everything.
        else
        {
            lookTimer = 0f;
            clicked = false;
        }
    }

    public void buyCow()
    {
        //If true, subtract money from total and add new cow to scene
        if(GetComponent<CurrencySystem>().subtractMoney(150))
        {
            Debug.Log("Bought Cow");
            animalArea1 = new Vector3(Random.Range(10.19f, 15.52f), 3.5f, Random.Range(5.85f, 10.98f));
            Instantiate(Resources.Load("Cow"), animalArea1, Quaternion.identity);
        }
        else
        {
            //not enough money!
        }
        
    }

    public void buyChicken()
    {
        //If true, subtract money from total and add new chicken to scene
        if (GetComponent<CurrencySystem>().subtractMoney(150))
        {

        }
    }

    public void buyPig()
    {
        Debug.Log("Bought pig");
        //If true, subtract money from total and add new pig to scene
        if (GetComponent<CurrencySystem>().subtractMoney(150))
        {
            animalArea2 = new Vector3(Random.Range(5.32f, 10.33f), 3.5f, Random.Range(11.79f, 16.70f));
            Instantiate(Resources.Load("Pig"), animalArea2, Quaternion.identity);
        }
    }

    public void buyCorn()
    {
        //If true, subtract money from total and add new corn to scene
        if (GetComponent<CurrencySystem>().subtractMoney(150))
        {
            Debug.Log("Bought Corn");
        }

    }

    public void buyWheat()
    {
        //If true, subtract money from total and add new wheat to scene
        if (GetComponent<CurrencySystem>().subtractMoney(150))
        {
            Debug.Log("Bought Wheat");
        }

    }

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
    }
}
