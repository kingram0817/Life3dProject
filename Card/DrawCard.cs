using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DrawCard : MonoBehaviour
{

    public Card card;
    public TextMeshProUGUI CardTitle;
    public TextMeshProUGUI CardSalary;
    public TextMeshProUGUI CardDesc;
    public TextMeshProUGUI CardDesc2;
    public Image CardIcon;
    public Image BonusIcon;
    public Image RedImage;
    public Image BlackImage;

    public TextMeshProUGUI HousePurchPrice;
    public TextMeshProUGUI HouseRedSale;
    public TextMeshProUGUI HouseBlackSale;
    public TextMeshProUGUI PurchaseLabel;
    public TextMeshProUGUI SpinForPriceLabel;
    public TextMeshProUGUI PurchaseRedLabel;
    public TextMeshProUGUI PurchaseBlackLabel;
    public TextMeshProUGUI BonusNumberLabel;
    public TextMeshProUGUI CardSalaryLabel;

    // Start is called before the first frame update
    void Start()
    {
        CardTitle.text = "";
        CardSalaryLabel.text = "";
        HouseRedSale.text = "";
        HouseBlackSale.text = "";
        HousePurchPrice.text = "";
        PurchaseLabel.text = "";
        SpinForPriceLabel.text = "";
        PurchaseRedLabel.text = "";
        PurchaseBlackLabel.text = "";
        CardDesc.text = "";
        CardSalary.text = "";
        CardDesc2.text = "";
        BonusNumberLabel.text = "";
        BonusIcon.gameObject.SetActive(false);
        BlackImage.gameObject.SetActive(false);
        RedImage.gameObject.SetActive(false);
        HouseRedSale.color = new Color32(255, 255, 255, 255);
        HouseBlackSale.color = new Color32(255, 255, 255, 255);



    }

    // Update is called once per frame
    void Update()
    {
        CardTitle.text = card.title;
        CardIcon.sprite = card.icon;
        HouseRedSale.color = new Color32(255, 255, 255, 255);
        HouseBlackSale.color = new Color32(255, 255, 255, 255);

        switch (card.cardType)
        {
            case "House":

                BlackImage.gameObject.SetActive(true);
                RedImage.gameObject.SetActive(true);
                HouseRedSale.text = card.RedSalePrice.ToString();
                HouseBlackSale.text = card.BlackSalePrice.ToString();
                HousePurchPrice.text = card.PurchasePrice.ToString();
                PurchaseLabel.text = "Purchase Price";
                SpinForPriceLabel.text = "Spin for Sale Price";
                PurchaseRedLabel.text = "Spin Red";
                PurchaseBlackLabel.text = "Spin Black";
                break;

            case "Action":
                CardDesc.text = card.description;
                CardDesc2.text = "Keep this card to get 100K at the end of the game.";
                break;

            case "Pet":
                CardDesc.text = card.description;
                CardDesc2.text = "Keep this card to get 100K at the end of the game.";
                break;

            case "Career":
                CardSalaryLabel.text = "SALARY";
                CardSalary.text = card.Salary.ToString();
                CardDesc2.text = card.description2;
                BonusNumberLabel.text = "Bonus Number";
                BonusIcon.gameObject.SetActive(true);
                BonusIcon.sprite = card.BonusIcon;
                break;

            case "College":
                CardSalaryLabel.text = "SALARY";
                CardSalary.text = card.Salary.ToString();
                CardDesc2.text = card.description2;
                BonusNumberLabel.text = "Bonus Number";
                BonusIcon.gameObject.SetActive(true);
                BonusIcon.sprite = card.BonusIcon;
                break;

        }

    }
}
