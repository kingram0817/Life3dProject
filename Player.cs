using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Card card;

    private List<Card> actionCards = new List<Card>();
    private List<Card> petCards = new List<Card>();
    private List<Card> houseCards = new List<Card>();
    private List<LoanCertificate> loanCertificates = new List<LoanCertificate>();

    public string playerName { get; set; } = "";

    public Player NextPlayer { get; set; }

    public Card CurrentCareer { get; set; }

    public bool MadeCareerChoice { get; set; }

    public int playerFunds { get; set; } = 0;

    public int numberOfKids { get; set; } = 0;

    public int numberOfPets { get; set; } = 0;

    public int playerTurnCounter { get; set; } = 0;

    public bool isPlayerRetired { get; set; }

    public Player(string name)
    {
        this.playerName = name;
        this.playerFunds = 200000;
        this.playerTurnCounter = 0;
        this.isPlayerRetired = false;
        this.NextPlayer = null;
        this.MadeCareerChoice = false;
    
    }

    //need a function to add an item to each type of list

    public void AddPlayerActionCard(Card card)
    {   
        //actionCards.Add(card); 
        
    }

}
