using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElixirSystemPlayerTwo : MonoBehaviour
{
    public bool isSpawning = false;
    public int elixir = 10;
    public TMP_Text ElixirDisplay;
    // IsSpawning is a method to keep the spamming checked.
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ElixirDisplay.text = elixir.ToString();
        if (Input.GetKeyDown(KeyCode.Alpha6) && !isSpawning && elixir > 0) // In the case they select and press 1.
        {
            isSpawning = true;
            elixir--;
            isSpawning = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) && !isSpawning && elixir > 0) // In the case they select and press 2.
        {
            isSpawning = true;
            elixir--;
            isSpawning = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) && !isSpawning && elixir > 0) // In the case they select and press 3.
        {
            isSpawning = true;
            elixir--;
            isSpawning = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) && !isSpawning && elixir > 0) // In the case they select and press 4.
        {
            isSpawning = true;
            elixir--;
            isSpawning = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0) && !isSpawning && elixir > 0) // In the case they select and press 5.
        {
            isSpawning = true;
            elixir--;
            isSpawning = false;
        }

    }
}
