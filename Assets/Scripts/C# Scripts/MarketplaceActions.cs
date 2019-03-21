using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketplaceActions : MonoBehaviour
{

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
