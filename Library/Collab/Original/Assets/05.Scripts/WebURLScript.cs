using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void btnOne()
    {
        Application.OpenURL("http://www.google.com");
    }

    public void btnTwo()
    {
        Application.OpenURL("http://www.bing.com");
    }

	public void btnThree()
	{
		Application.OpenURL("http://www.bing.com");
	}


	// Update is called once per frame
	void Update()
    {
        
    }
}
