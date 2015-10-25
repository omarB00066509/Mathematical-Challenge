using UnityEngine;
using System.Collections;

public class PlayerLives : MonoBehaviour {

    public Texture2D health1;
    public Texture2D health2;
    public Texture2D health3;

    private int P1labelY = (Screen.width * 8) / 10;
    private int P2labelY = (Screen.width * 2) / 10;

    private int labelX = ((Screen.height * 5) / 100) + 50;
    private int labelWidth = 200;
    private int labelHeight = 50;

    public int startingHealth = 3;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   //The amount of health the player has after upgrades and damage done

    bool isDead;                                                // True when the player gets damaged.


    void Start()
    {
        // Set the initial health of the player.
        currentHealth = startingHealth;
    }


    private void OnGUI()
    {
        DisplayHealthBar(currentHealth);
        if (currentHealth <= 0)
        {
            int GameOver = 0;
            //int Game_Over_Level = 2;
            Application.LoadLevel(GameOver);
        }
    }


    public void WrongAnswer()
    {

        // Reduce the current health.
        currentHealth --;

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }


    void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;
    }

    private void DisplayHealthBar(int i)
    {
        GUI.Label(new Rect(P1labelY, labelX, labelWidth, labelHeight), getImage(i));
    }

    private Texture2D getImage(int i)
    {
        if (currentHealth == 3) { return health3; }
        else if (currentHealth == 2) { return health2; }
        else if (currentHealth == 1) { return health1; }
        else { return null; }
    }

}