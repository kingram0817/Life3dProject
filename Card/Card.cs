using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Card", menuName = "Cards")]
public class Card : ScriptableObject
{

    public string title;
    public string cardType;
    public string description;
    public string description2;
    public bool keepThisCard; //check if its one of those hold til the end cards
    public int PurchasePrice;
    public int RedSalePrice;
    public int BlackSalePrice;
    public int Salary;
    public int BonusNumber;
    public Sprite icon;
    public Sprite BonusIcon;

}
