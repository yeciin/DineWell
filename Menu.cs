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
    public GameObject[] maindishModels;
    public GameObject[] dessertModels;
    public GameObject[] drinkModels;
    public GameObject backButton;
    public GameObject placeButton;
    public GameObject backButton3DActive;



    void Start()
    {
        ActivateMainMenuButtons()
    }

    public void openMainMenu()
    {
        mainDishesDesign.SetActive(true);
        closeAppetizers();
        closeDesserts();
        closeMainDishes();
        closeDrinks();
        backButton.SetActive(false);
        mainsButton.SetActive(true);
        appetizersButton.SetActive(true);
        drinksButton.SetActive(true);
        dessertsButton.SetActive(true);
    }

    public void openAppetizers()
    {
        DeactivateMainMenuButtons();
        backButton.SetActive(true);
        ActivateAppetizerButtons();

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

}

