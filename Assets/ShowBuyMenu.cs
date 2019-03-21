using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBuyMenu : MonoBehaviour
{
    public GameObject previousMenu;
    public GameObject menu;
    
    private bool show;
    private bool clicked;

    // Whether the Google Cardboard user is gazing at this button.
    private bool isLookedAt = false;

    // How long the user can gaze at this before the button is clicked.
    public float timerDuration = 3f;

    // Count time the player has been gazing at the button.
    private float lookTimer = 0f;

    // Graphical progress indicator.
    private GameObject gazeTimer;

    // Use this for initialization
    void Start()
    {
        clicked = false;
        show = false;
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
                    Debug.Log("open buy menu");
                    //GetComponent<Button>().onClick.Invoke();
                    //abover line is triggering the button click function of the object.
                    if (!show)
                    {
                        menu.SetActive(true);
                        previousMenu.SetActive(false);
                        show = true;
                    }
                    clicked = true;
                }


            }
        }

        // Not gazing at this anymore, reset everything.
        else
        {
            lookTimer = 0f;
            clicked = false;
            show = false;
        }
    }

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
    }
}
