using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public List<GameObject> activeItems;
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
        activeItems = new List<GameObject>();
       addActiveItems(mainMenuButtons);
    }

    public void addActiveItem(GameObject item)
    {
        item.SetActive(true);
        activeItems.Add(item);
    }

    public void addActiveItems(GameObject[] items)
    {
        removeAllActiveItems();
        
        foreach (GameObject item in items)
        {
            item.SetActive(true);
            activeItems.Add(item);
        }
    }

    public void removeActiveItem(GameObject item)
    {
        item.SetActive(false);
        activeItems.Remove(item);
    }

    public void removeAllActiveItems()
    {
        foreach (GameObject item in activeItems)
        {
            item.SetActive(false);
        }
        activeItems.Clear();
    }

    public void openMainMenu()
    {
        backButton.SetActive(true);
        addActiveItems(mainItems);
    }
    public void openAppetizers()
    {
        backButton.SetActive(true);
        addActiveItems(appetizersItems);
    }
    public void openDesserts()
    {
        backButton.SetActive(true);
        addActiveItems(dessertItems);
    }
    public void openDrinks()
    {
        backButton.SetActive(true);
        addActiveItems(drinksItems);
    }







    // public void ActivateMainMenuButtons()
    // {
    //     foreach (GameObject button in mainMenuButtons)
    //     {
    //         if (button != null)
    //         {
    //             button.SetActive(true);
    //         }
    //     }
    // }
    // public void DeactivateMainMenuButtons()
    // {
    //     foreach (GameObject button in mainMenuButtons)
    //     {
    //         if (button != null)
    //         {
    //             button.SetActive(false);
    //         }
    //     }
    // }
    // public void ActivateAppetizerButtons()
    // {
    //     foreach (GameObject button in appetizersItems)
    //     {
    //         if (button != null)
    //         {
    //             button.SetActive(true);
    //         }
    //     }
    // }
    // public void DeactivateAppetizerButtons()
    // {
    //     foreach (GameObject button in appetizersItems)
    //     {
    //         if (button != null)
    //         {
    //             button.SetActive(false);
    //         }
    //     }
    // }
    // public void ActivateDessertButtons()
    // {
    //     foreach (GameObject button in dessertItems)
    //     {
    //         if (button != null)
    //         {
    //             button.SetActive(true);
    //         }
    //     }
    // }
    // public void DeactivateDessertButtons()
    // {
    //     foreach (GameObject button in dessertItems)
    //     {
    //         if (button != null)
    //         {
    //             button.SetActive(false);
    //         }
    //     }
    // }
    // public void ActivateDrinkButtons()
    // {
    //     foreach (GameObject button in drinksItems)
    //     {
    //         if (button != null)
    //         {
    //             button.SetActive(true);
    //         }
    //     }
    // }
    // public void DeactivateDrinkButtons()
    // {
    //     foreach (GameObject button in drinksItems)
    //     {
    //         if (button != null)
    //         {
    //             button.SetActive(false);
    //         }
    //     }
    // }


}

