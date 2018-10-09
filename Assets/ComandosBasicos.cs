using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ComandosBasicos : MonoBehaviour {

	
	public void CarregaCena(string nome){
		SceneManager.LoadScene(nome);
	}

}
