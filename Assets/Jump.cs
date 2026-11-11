using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Unity.VectorGraphics;


public class Jump : MonoBehaviour
{

    public int JumpCount = 0;
    public Text JumpText;

    public class Shape
    {
        public virtual void MakeSound()
        {
            Debug.Log("Shape");
        }
    }

    public class Square : Shape
    {
        public override void MakeSound()
        {
            Debug.Log ("Square");
        }
    }

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
