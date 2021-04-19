using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowChests : MonoBehaviour
{
    [SerializeField] GameObject chestParentController;
    private bool chestActive;




    public void ShowChest()
    {
        chestParentController.SetActive(true);
        chestActive = true;
    }

    public void HideChest()
    {
        chestParentController.SetActive(false);
        chestActive = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
