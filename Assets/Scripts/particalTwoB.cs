using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particalTwoB : MonoBehaviour
{
    public ParticleSystem MyparticleSystem;

    public Renderer renderer;

    private Material mt;

    public ParticleSystem MyparticleSystem2;

    public Renderer renderer2;

    private Material mt2;

    private float partTime;
    private float LightTerminal = 3f;
    private float AlphaTerminal = 0f;

    private float Lightminx = 1.5f;
    private float Lightmaxx = 3f;
    private float Desloveminx = 0f;
    private float DesloveMaxx = 1f;
    private float Alphaminx = 0f;
    private float Alphamaxx = 1f;

    private float LightTerminal2 = 3f;
    private float AlphaTerminal2 = 1f;
    private float DesloveTerminal2 = 0f;
    private float Lightminx2 = 1.5f;
    private float Lightmaxx2 = 4f;
    private float Desloveminx2 = 0f;
    private float DesloveMaxx2 = 1f;
    private float Alphaminx2 = 0f;
    private float Alphamaxx2 = 1f;

    private float times = 0;
    private string LigjtStrength = "Vector1_5D1651DD";
    private string Deslove = "Vector1_70FFF24C";
    private string Alpha = "Vector1_DC8FDE95";



    // Use this for initialization
    void Start ()
	{
	    mt = renderer.materials[0];
	    mt2 = renderer2.materials[0];
	    partTime = 5f;
	    Debug.Log(MyparticleSystem.time);
	}
    private bool change = false;
    private bool change2 = false;
    public GameObject objParent;

    public GameObject objSword;
    // Update is called once per frame
    void Update () {

	    if (Input.GetMouseButton(1))
	    {
	        MyparticleSystem.Play();
	       
            change = true;
	    }
        if (Input.GetMouseButton(0))
        {
            MyparticleSystem.Play();
       
            change2 = true;
        }
        if (change2 == true && times < partTime)
        {
            if (times >= 0.9f)
            {
                change2 = false;
                times = 0f;
                objSword.transform.parent = objParent.transform;
                objSword.transform.position = objParent.transform.GetChild(0).transform.position;
                objSword.transform.rotation = objParent.transform.GetChild(0).transform.rotation;
                objSword.transform.localScale = objParent.transform.GetChild(0).transform.localScale;
            }
            else
            {
                times += Time.deltaTime / 5f;
                LightTerminal2 = Mathf.Lerp(Lightmaxx2, Lightminx2, times);
                mt.SetFloat(LigjtStrength, LightTerminal2);
                AlphaTerminal2 = Mathf.Lerp(Alphamaxx2, Alphaminx2, times);
                mt.SetFloat(Alpha, AlphaTerminal2);
                DesloveTerminal2 = Mathf.Lerp(Desloveminx2, DesloveMaxx2, times);
                mt.SetFloat(Deslove, DesloveTerminal2);
            }
        }
        if (change==true&&times<partTime)
	    {
	        if (times >= 0.9f)
	        {
	            change = false;
	            times = 0f;
	            objSword.transform.parent = objParent.transform;
	            objSword.transform.position = objParent.transform.GetChild(0).transform.position;
	            objSword.transform.rotation = objParent.transform.GetChild(0).transform.rotation;
	            objSword.transform.localScale = objParent.transform.GetChild(0).transform.localScale;
            }
	        else
	        {
                
	            times += Time.deltaTime/5f;
	            LightTerminal = Mathf.Lerp(Lightminx, Lightmaxx, times);
	            mt.SetFloat(LigjtStrength, LightTerminal);
	            AlphaTerminal = Mathf.Lerp(Alphaminx, Alphamaxx, times);
                mt.SetFloat(Alpha,AlphaTerminal);
	        }
        }
	}
}
