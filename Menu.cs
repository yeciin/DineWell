using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject[] mainMenu;
    public GameObject[] Mains;
    public GameObject[] Appetizers;
    public GameObject[] Drinks;
    public GameObject[] Desserts;
    public GameObject[] mainItemsDetail;
    public GameObject[] dessertItemsDetail;
    public GameObject[] drinkItemsDetail;
    public GameObject[] appetizerItemsDetail;
    public GameObject placeItem;
    public List<GameObject> activeUI = new List<GameObject>();
    public GameObject backbutton;
    public GameObject[] models;
    public GameObject ActiveARBackButton;

    void Start()
    {
        RemoveFromActiveUI();
        AddToActiveUI(mainMenu);
    }

    public void AddToActiveUI(GameObject[] objs)
    {
        RemoveFromActiveUI();
        foreach (GameObject obj in objs)
        {
            if (obj != null && !activeUI.Contains(obj))
            {
                activeUI.Add(obj);
                obj.SetActive(true);
            }
        }
    }
    public void AddToActiveUISingular(GameObject obj)
    {
        RemoveFromActiveUI();

        if (obj != null && !activeUI.Contains(obj))
        {
            activeUI.Add(obj);
            obj.SetActive(true);
        }
    }

    public void RemoveFromActiveUI()
    {
        foreach (GameObject obj in activeUI)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
        activeUI.Clear();
    }
    public bool IsAnyActive(GameObject[] objects)
    {
        foreach (GameObject obj in objects)
        {
            if (obj != null && obj.activeSelf)
            {
                return true;
            }
        }
        return false;
    }
    public void goAppetizers()
    {
        AddToActiveUI(Appetizers);
        backbutton.SetActive(true);
    }
    public void goMains()
    {
        AddToActiveUI(Mains);
        backbutton.SetActive(true);

    }
    public void goDrinks()
    {
        AddToActiveUI(Drinks);
        backbutton.SetActive(true);

    }
    public void goDesserts()
    {
        AddToActiveUI(Desserts);
        backbutton.SetActive(true);

    }
    public void mainItem1Details()
    {
        AddToActiveUISingular(mainItemsDetail[0]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }
    public void mainItem2Details()
    {
        AddToActiveUISingular(mainItemsDetail[1]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }
    public void mainItem3Details()
    {
        AddToActiveUISingular(mainItemsDetail[2]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }
    public void mainItem4Details()
    {
        AddToActiveUISingular(mainItemsDetail[3]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }
    public void dessertItem1Details()
    {
        AddToActiveUISingular(dessertItemsDetail[0]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void dessertItem2Details()
    {
        AddToActiveUISingular(dessertItemsDetail[1]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void dessertItem3Details()
    {
        AddToActiveUISingular(dessertItemsDetail[2]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void dessertItem4Details()
    {
        AddToActiveUISingular(dessertItemsDetail[3]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }
    public void drinkItem1Details()
    {
        AddToActiveUISingular(drinkItemsDetail[0]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void drinkItem2Details()
    {
        AddToActiveUISingular(drinkItemsDetail[1]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void drinkItem3Details()
    {
        AddToActiveUISingular(drinkItemsDetail[2]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void drinkItem4Details()
    {
        AddToActiveUISingular(drinkItemsDetail[3]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }
    public void appetizerItem1Details()
    {
        AddToActiveUISingular(appetizerItemsDetail[0]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void appetizerItem2Details()
    {
        AddToActiveUISingular(appetizerItemsDetail[1]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void appetizerItem3Details()
    {
        AddToActiveUISingular(appetizerItemsDetail[2]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void appetizerItem4Details()
    {
        AddToActiveUISingular(appetizerItemsDetail[3]);
        backbutton.SetActive(true);
        placeItem.SetActive(true);
    }

    public void MainItem1DisplayModel()
    {
        if (mainItemsDetail[0].activeSelf)
        {
            RemoveFromActiveUI();
            models[0].SetActive(true);
            backbutton.SetActive(true);
            ActiveARBackButton.SetActive(true);
        }
    }
    public void MainItem2DisplayModel()
    {
        if (mainItemsDetail[1].activeSelf)
        {
            RemoveFromActiveUI();
            models[1].SetActive(true);
            models[16].SetActive(true);
            backbutton.SetActive(true);
            ActiveARBackButton.SetActive(true);
        }
    }

    public void MainItem3DisplayModel()
    {
        RemoveFromActiveUI();
        models[2].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void MainItem4DisplayModel()
    {
        RemoveFromActiveUI();
        models[3].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }
    public void AppetizerItem1DisplayModel()
    {
        RemoveFromActiveUI();
        models[4].SetActive(true);
        models[16].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void AppetizerItem2DisplayModel()
    {
        RemoveFromActiveUI();
        models[5].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void AppetizerItem3DisplayModel()
    {
        RemoveFromActiveUI();
        models[6].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void AppetizerItem4DisplayModel()
    {
        RemoveFromActiveUI();
        models[7].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }
    public void DrinkItem1DisplayModel()
    {
        RemoveFromActiveUI();
        models[8].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void DrinkItem2DisplayModel()
    {
        RemoveFromActiveUI();
        models[9].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void DrinkItem3DisplayModel()
    {
        RemoveFromActiveUI();
        models[10].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void DrinkItem4DisplayModel()
    {
        RemoveFromActiveUI();
        models[11].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }
    public void DessertItem1DisplayModel()
    {
        RemoveFromActiveUI();
        models[12].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void DessertItem2DisplayModel()
    {
        RemoveFromActiveUI();
        models[13].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void DessertItem3DisplayModel()
    {
        RemoveFromActiveUI();
        models[14].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void DessertItem4DisplayModel()
    {
        RemoveFromActiveUI();
        models[15].SetActive(true);
        backbutton.SetActive(true);
        ActiveARBackButton.SetActive(true);
    }

    public void goBack()
    {
        if (IsAnyActive(mainItemsDetail))
        {
            AddToActiveUI(Mains);
            backbutton.SetActive(true);
        }
        else if (IsAnyActive(dessertItemsDetail))
        {
            AddToActiveUI(Desserts);
            backbutton.SetActive(true);
        }
        else if (IsAnyActive(drinkItemsDetail))
        {
            AddToActiveUI(Drinks);
            backbutton.SetActive(true);
        }
        else if (IsAnyActive(appetizerItemsDetail))
        {
            AddToActiveUI(Appetizers);
            backbutton.SetActive(true);
        }
        else if (IsAnyActive(Mains) || IsAnyActive(Desserts) || IsAnyActive(Appetizers) || IsAnyActive(Drinks))
        {
            AddToActiveUI(mainMenu);
        }
        else if (models[0].activeSelf)
        {
            models[0].SetActive(false);
            mainItem1Details();
        }
        else if (models[1].activeSelf)
        {
            models[1].SetActive(false);
            models[16].SetActive(false);
            mainItem2Details();
        }
    }

}
// public GameObject backButton;
// public GameObject placeButton;
// public GameObject backButton3DActive;

// public Item[] mainMenu;
// public Item[] appetizers;
// public Item[] mains;
// public Item[] desserts;
// public Item[] drinks;
// public void addActiveItems(Item[] items)
// {
//     Debug.Log("Adding active items...");
//     removeAllActiveItems();

//     foreach (Item item in items)
//     {
//         if(item.decoration!=null){
//             item.decoration.SetActive(true);
//         }
//         Debug.Log($"Setting up item: {item.button.name}");
//         // Clear previous listeners to avoid stacking
//         item.button.onClick.RemoveAllListeners();
//         item.placeItemButton.onClick.RemoveAllListeners();

//         // Add new listener for the main button
//         item.button.onClick.AddListener(() =>
//         {
//             Debug.Log($"Button clicked: {item.button.name}");
//             removeAllActiveItems();
//             if (item.details != null)
//             {
//                 Debug.Log("Showing details");
//                 item.details.SetActive(true);
//             }

//             if (item.model != null && item.placeItemButton != null)
//             {
//                 // Add new listener for the placeItemButton inside the main button's listener
//                 item.placeItemButton.onClick.AddListener(() =>
//                 {
//                     Debug.Log("Placing item model");
//                     removeAllActiveItems();
//                     item.model.SetActive(true);
//                 });
//             }
//         });

//         // Show the main button for the item
//         item.button.gameObject.SetActive(true);
//         activeItems.Add(item);
//     }
// }

// public void removeAllActiveItems()
// {
//     Debug.Log("Removing all active items");
//     foreach (Item item in activeItems)
//     {
//         Debug.Log($"Deactivating item: {item.button.name}");
//         item.button.gameObject.SetActive(false);
//         if (item.details != null)
//         {
//             item.details.SetActive(false);
//         }
//         if (item.model != null)
//         {
//             item.model.SetActive(false);
//         }
//     }

//     // Clear the list of active items
//     activeItems.Clear();
// }

// public void openMains()
// {
//     ShowBackButton(true);
//     addActiveItems(mains);
// }

// public void openAppetizers()
// {
//     ShowBackButton(true);
//     addActiveItems(appetizers);
// }

// public void openDesserts()
// {
//     ShowBackButton(true);
//     addActiveItems(desserts);
// }

// public void openDrinks()
// {
//     ShowBackButton(true);
//     addActiveItems(drinks);
// }

// private void ShowBackButton(bool show)
// {
//     backButton.SetActive(show);
// }

// [System.Serializable]
// public class Item
// {
//     public Button button;
//     public GameObject details;
//     public GameObject model;
//     public Button placeItemButton;
//     public GameObject decoration;
// }

