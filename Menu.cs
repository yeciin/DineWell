using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public GameObject[] mainMenuButtons;
    public GameObject[] mainItems;
    public GameObject[] appetizersItems;
    public GameObject[] dessertItems;
    public GameObject[] drinksItems;
    public GameObject[] mainItemDetails;
    public GameObject[] appetizerItemDetails;
    public GameObject[] drinkItemDetails;
    public GameObject[] dessertItemDetails;
    public GameObject[] appetizerModels;
    public GameObject[] mainDishModels;
    public GameObject[] dessertModels;
    public GameObject[] drinkModels;
    public GameObject backButton;
    public GameObject placeButton;
    public GameObject backButton3DActive;



    void Start()
    {
        ActivateMainMenuButtons();
    }

    public void openMainMenu()
    {
        ActivateMainMenuButtons();
        DeactivateAppetizerButtons();
        DeactivateDessertButtons();
        DeactivateDrinkButtons();
    }

    public void openAppetizers()
    {
        DeactivateMainMenuButtons();
        backButton.SetActive(true);
        ActivateAppetizerButtons();
        //should add function here that disables ItemDetails in case we are going back
    }










    public void ActivateMainMenuButtons()
    {
        foreach (GameObject button in mainMenuButtons)
        {
            if (button != null)
            {
                button.SetActive(true);
            }
        }
    }
    public void DeactivateMainMenuButtons()
    {
        foreach (GameObject button in mainMenuButtons)
        {
            if (button != null)
            {
                button.SetActive(false);
            }
        }
    }
    public void ActivateAppetizerButtons()
    {
        foreach (GameObject button in appetizersItems)
        {
            if (button != null)
            {
                button.SetActive(true);
            }
        }
    }
    public void DeactivateAppetizerButtons()
    {
        foreach (GameObject button in appetizersItems)
        {
            if (button != null)
            {
                button.SetActive(false);
            }
        }
    }
    public void ActivateDessertButtons()
    {
        foreach (GameObject button in dessertItems)
        {
            if (button != null)
            {
                button.SetActive(true);
            }
        }
    }
    public void DeactivateDessertButtons()
    {
        foreach (GameObject button in dessertItems)
        {
            if (button != null)
            {
                button.SetActive(false);
            }
        }
    }
    public void ActivateDrinkButtons()
    {
        foreach (GameObject button in drinksItems)
        {
            if (button != null)
            {
                button.SetActive(true);
            }
        }
    }
    public void DeactivateDrinkButtons()
    {
        foreach (GameObject button in drinksItems)
        {
            if (button != null)
            {
                button.SetActive(false);
            }
        }
    }


}

