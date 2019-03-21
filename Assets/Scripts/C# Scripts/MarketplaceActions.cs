using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketplaceActions : MonoBehaviour
{
    public Vector3 animalArea1;
    public Vector3 animalArea2;
    public Vector3 cropArea;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

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
    
}
