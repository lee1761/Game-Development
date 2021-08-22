using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class Dialogue : MonoBehaviour
{
	public TextMeshProUGUI textComponent;

	[TextArea(10,10)]
	public string[] lines;
	public float textSpeed;
    
    private int index;



	public void Click()
    {
    	SceneManager.LoadScene(2);
        
    }
    void StartDialogue()
    {
        index =0;
        StartCoroutine(TypeLine());

    }

   
   void Start()
    {
        textComponent.text = "   ";
        StartDialogue();    
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
            {
        if(textComponent.text == lines[index])
        {
            NextLine();
        }
        else{
            StopAllCoroutines();
            textComponent.text = lines[index];
        }
    }

        }
    

    
    IEnumerator TypeLine()
    {
    	foreach (char c in lines[index].ToCharArray())
    	{
    		textComponent.text += c;
    		yield return new WaitForSeconds(textSpeed);
    	}
    }
    
     void NextLine()
    {
        
        if(index < lines.Length - 1)
        {
            index ++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else{
            //gameObject.SetActive(false);
        }
    
    }



}

