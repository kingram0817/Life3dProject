using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public GameManager Gm;
    //player UI colors: DO NOT DELETE
    /* 1 = FF00A5
     * 2 = 00BFFF
     * 3 = 00FF04
     * 4 = F7FF19
     */

    //Menus
    public GameObject WelcomeMenu;
    public GameObject ChoiceMenu;
    public GameObject PlayingUI;
    public GameObject InteractionMenu;

    //StartMenu

    //Welcome Menu
    public Button OnePlayerBtn;
    public Button TwoPlayerBtn;
    public Button ThreePlayerBtn;
    public Button FourPlayerBtn;

    //Career Choice Menu
    public Button careerChoice;
    public Button collegeChoice;
    public TextMeshProUGUI playerNameChoiceMenu;

    //Player UI Grid

    //Player Info
    public TextMeshProUGUI playerNameInfo;
    public TextMeshProUGUI playerCash;
    public TextMeshProUGUI playerCareer;
    public TextMeshProUGUI playerKids;
    public TextMeshProUGUI playerPets;
    public TextMeshProUGUI playerHouse;

    //Show 2 cards Menu

    void Update()
    {
        playerMenu();
    }

    public void playerMenu()
    {
        playerNameInfo.text = Gm.CurrentPlayer.name;
        playerCash.text = Gm.CurrentPlayer.playerFunds.ToString();
        playerCareer.text = Gm.CurrentPlayer.CurrentCareer.title;
        playerKids.text = Gm.CurrentPlayer.numberOfKids.ToString();
        playerPets.text = Gm.CurrentPlayer.numberOfPets.ToString();
        playerHouse.text = "No House";

    }






}
