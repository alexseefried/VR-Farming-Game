using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Upgrade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void upgradeAnimal(GameObject animalToUpgrade)
    {
        //check if already upgraded
        //if (upgraded)
        //{

            //upgrade cow
            if (animalToUpgrade.name == "Cow")
            {

                //subtract money from user
                //if user has enough money, subtract from total and upgrade cow
                if (GetComponent<CurrencySystem>().subtractMoney(80)) //returns boolean
                {
                    //replace cow with larger cow
                    //Update user money
                }
                //if user does not have enough money, let user know and dont subtract anything
                else
                {
                    //display message "Not enough money to upgrade"
                }
            }
            //upgrade chicken
            else if (animalToUpgrade.name == "Chicken")
            {
                //subtract money from user
                //if user has enough money, subtract from total and upgrade chicken
                if (GetComponent<CurrencySystem>().subtractMoney(80))
                {
                    //replace chicken with larger chicken
                    //Update user money
                }
                //if user does not have enough money, let user know and dont subtract anything
                else
                {
                    //display message "Not enough money to upgrade"
                }
            }
            //upgrade pig
            else if (animalToUpgrade.name == "Pig")
            {
                //subtract money from user
                //if user has enough money, subtract from total and upgrade pig
                if (GetComponent<CurrencySystem>().subtractMoney(80))
                {
                    //replace pig with larger pig
                    //Update user money
                }
                //if user does not have enough money, let user know and dont subtract anything
                else
                {
                    //display message "Not enough money to upgrade"
                }
            }
        //}
    }

    public void upgradeCrop(GameObject cropToUpgrade)
    {
        //check if upgraded before upgrading
        //subtract money from user
        //if user has enough money, subtract from total and upgrade crop
    }

    public void upgradeBarn(GameObject barn)
    {
        Vector3 barnPosition = new Vector3(25.69f, 2.77f, 11.57f);
        //subtract money from user
        //if user has enough money, subtract from total and upgrade barn
        if (GetComponent<CurrencySystem>().subtractMoney(200))
        {
            //remove Barn
            Destroy(barn);
            //create new barn lvl2
            Instantiate(Resources.Load("BarnLv2"), barnPosition, Quaternion.identity);

        }
        else
        {
            //not enough money to upgrade
        }
            
    }
}
