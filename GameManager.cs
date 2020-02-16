using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum GameState { WELCOME, PLAYERSELECT, PLAYERSPIN, PLAYERMOVE, PLAYERACTION, PLAYING, PAUSED, GAMEOVER, QUIT }

public class GameManager : MonoBehaviour
{

    private GameState state;
    private Player player;
    public MenuManager MM;
    private List<Player> players = new List<Player>();
    private List<Player> retiredPlayers = new List<Player>();

    public Card Athlete;
    public Card VideoGameDesigner;

    public Player p1;
    public Player p2;
    public Player p3;
    public Player p4;

    public List<Tile> collegePath = new List<Tile>();
    public List<Tile> lifePath = new List<Tile>();

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public Transform spawnP1;
    public Transform spawnP2;
    public Transform spawnP3;
    public Transform spawnP4;
    

    public int numberOfPlayers { get; set; } = 0;

    public Player CurrentPlayer { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.WELCOME;

        numberOfPlayers = 0;
        Player p1 = new Player("Player 1");
        Player p2 = new Player("Player 2");
        Player p3 = new Player("Player 3");
        Player p4 = new Player("Player 4");

      
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {

            case GameState.WELCOME:
                //Debug.Log("Changing to the " + state + " state!");
                CurrentPlayer = p1;
                break;
            case GameState.PLAYERSELECT:
               // Debug.Log("Changing to the " + state + " state!");
                MM.WelcomeMenu.SetActive(false);
                SetNextPlayer();
                state = GameState.PLAYERSPIN;

                break;
            case GameState.PLAYERSPIN:
                // Debug.Log("Changing to the " + state + " state!");
                PlayerSpin();

                break;
            case GameState.PLAYERMOVE:
                 //Debug.Log("Changing to the " + state + " state!");
                
                break;
            case GameState.PLAYERACTION:
                // Debug.Log("Changing to the " + state + " state!");
                
                break;

            case GameState.PLAYING:

                break;
            case GameState.PAUSED:

                break;
            case GameState.GAMEOVER:

                break;
            case GameState.QUIT:
                QuitGame();
                break;

            default:
                break;
        }

    }

    
    #region STATES

    public void PlayerSpin()
    {
        Debug.Log(CurrentPlayer.MadeCareerChoice);
        if (CurrentPlayer.MadeCareerChoice == false)
        {
            MM.ChoiceMenu.SetActive(true);
        }
        else
        {
            //MM.PlayingUI.SetActive(true);
            
        }
        MM.InteractionMenu.SetActive(true);

    }

    public void PlayerMove(Player player)
    {
        //this.player moves on the board
        //when vehicle is done moving change to player action state
        state = GameState.PLAYERACTION;
    }

    public void PlayerAction(Player player)
    {
        //this.player is shown the tile info -> displays whatever card is on the tile.
        //player takes said action.
        //check to see if they need to roll again
        //go to the next player
        //after setting next player go to player spin again
        state = GameState.PLAYERSELECT;

    }


    public void GameOver()
    {
        //change to this state once all players have retired
        //perform the math to determine the winner
        //display winner
    }

    public void QuitGame()
    {
        Debug.Log("Quitter");
        Application.Quit();
    }

    #endregion

    #region STATE ACTIONS

    public void SetNumberOfPlayers(Button btn)
    {
        string buttonClicked = btn.name;
        switch (buttonClicked)
        {
            case "OnePlayerBtn":
                numberOfPlayers = 1;
                CreatePlayers(1);
                
               // Debug.Log(numberOfPlayers);
                state = GameState.PLAYERSELECT;
                break;

            case "TwoPlayerBtn":
                numberOfPlayers = 2;
                CreatePlayers(2);
              
               // Debug.Log(numberOfPlayers);
                state = GameState.PLAYERSELECT;
                break;

            case "ThreePlayerBtn":
                numberOfPlayers = 3;
                CreatePlayers(3);
                
               // Debug.Log(numberOfPlayers);
                state = GameState.PLAYERSELECT;
                break;

            case "FourPlayerBtn":
                numberOfPlayers = 4;
                CreatePlayers(4);
               
               // Debug.Log(numberOfPlayers);
                state = GameState.PLAYERSELECT;
                break;

        }

    }

    public void SetPlayerCareer(Button btn)
    {
        string buttonClicked = btn.name;
        switch (buttonClicked)
        {
            case "CareerBtn":
                Debug.Log(CurrentPlayer.MadeCareerChoice);
                this.CurrentPlayer.MadeCareerChoice = true;
                MM.ChoiceMenu.SetActive(false);
                CurrentPlayer.CurrentCareer = Athlete;
                
                //send them to function to display 2 career cards
                // for them to choose from
                state = GameState.PLAYERSPIN;
                break;

            case "CollegeBtn":
                Debug.Log(CurrentPlayer.MadeCareerChoice);
                this.CurrentPlayer.MadeCareerChoice = true;
                MM.ChoiceMenu.SetActive(false);
                CurrentPlayer.CurrentCareer = VideoGameDesigner;
                
                //send them to function that has them pay the bank 100k
                state = GameState.PLAYERSPIN;
                break;


        }
    }

    public void CreatePlayers(int howMany)
    {
      
        switch (howMany)
        {
            case 1:
                Instantiate(player1, spawnP1.position, spawnP1.rotation);
                players.Add(p1);
                break;
            case 2:
                Instantiate(player1, spawnP1.position, spawnP1.rotation);
                Instantiate(player2, spawnP2.position, spawnP2.rotation);
                players.Add(p1);
                players.Add(p2);
                break;
            case 3:
                Instantiate(player1, spawnP1.position, spawnP1.rotation);
                Instantiate(player2, spawnP2.position, spawnP2.rotation);
                Instantiate(player3, spawnP3.position, spawnP3.rotation);
                players.Add(p1);
                players.Add(p2);
                players.Add(p3);
                break;
            case 4:
                Instantiate(player1, spawnP1.position, spawnP1.rotation);
                Instantiate(player2, spawnP2.position, spawnP2.rotation);
                Instantiate(player3, spawnP3.position, spawnP3.rotation);
                Instantiate(player4, spawnP4.position, spawnP4.rotation);
                players.Add(p1);
                players.Add(p2);
                players.Add(p3);
                players.Add(p4);
                break;
        }


    }

    #endregion


    public void SetNextPlayer()
    {
        switch (numberOfPlayers)
        {
            case 1:
                p1.NextPlayer = p1;
                break;
            case 2:
                p1.NextPlayer = p2;
                p2.NextPlayer = p1;
                break;
            case 3:
                p1.NextPlayer = p2;
                p2.NextPlayer = p3;
                p3.NextPlayer = p1;
                break;
            default:
                p1.NextPlayer = p2;
                p2.NextPlayer = p3;
                p3.NextPlayer = p4;
                p4.NextPlayer = p1;
                break;
        }
    }

}
