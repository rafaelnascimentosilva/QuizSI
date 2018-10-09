using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemaJogo : MonoBehaviour
{

    public Button btnPlay;
    public Text txtNomeTema;

    public GameObject InfoTema;
	  public Text txtInfoTema;
    public GameObject EstrelaON1;
    public GameObject EstrelaON2;
    public GameObject EstrelaON3;

  
    public string[] nomeTema;
    private int idTema;

    void Start()
    {
		txtNomeTema.text = nomeTema[0];
		InfoTema.SetActive(false);
		txtInfoTema.text = "";
		
		EstrelaON1.SetActive(false);
		EstrelaON2.SetActive(false);
		EstrelaON3.SetActive(false);

    }

   public void SelecionarTema(int i){
	   idTema = i;
	   InfoTema.SetActive(true);
	   txtNomeTema.text = nomeTema[idTema];
	   btnPlay.interactable  = true;	
   }
   public void Jogar(){
	   SceneManager.LoadScene("T"+idTema);
   }
}
