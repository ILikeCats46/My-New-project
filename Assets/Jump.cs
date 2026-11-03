using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Jump : MonoBehaviour
{

    public int JumpCount = 0;
    public Text JumpText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("I am jumping");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            PlayerMoved();
            JumpText.text = JumpCount.ToString();

        }
    }

    public void PlayerMoved()
    {
        JumpCount++;
    }

    void OnMouseOver()
    {

        Debug.Log("Player.");
    }
}
