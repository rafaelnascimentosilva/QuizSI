using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemaInfo : MonoBehaviour {

	public int idTema;
	public GameObject EstrelaON1;
    public GameObject EstrelaON2;
    public GameObject EstrelaON3;
	void Start () {
		EstrelaON1.SetActive(false);
		EstrelaON2.SetActive(false);
		EstrelaON3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
