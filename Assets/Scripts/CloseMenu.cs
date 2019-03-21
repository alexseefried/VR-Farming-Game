
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CloseMenu : MonoBehaviour
{
    public GameObject menu;
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
                    Debug.Log("close button hit.");
                    menu.SetActive(false);
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

    // Record whether Google Cardboard user is gazing at the button.
    // gazedAt: Set it to the value passed from event trigger.
    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
    }

}