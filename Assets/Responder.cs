using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Responder : MonoBehaviour
{
    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;

    public Text infoRespostas;

    public string[] perguntas;
    public string[] alternativasA;
    public string[] alternativasB;
    public string[] alternativasC;
    public string[] alternativasD;
    public string[] corretas;


    private int idPergunta;
    private float acertos;
    private float questoes;
    private float media;

    void Start()
    {
        idPergunta = 0;
        questoes = perguntas.Length;

        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativasA[idPergunta];
        respostaB.text = alternativasB[idPergunta];
        respostaC.text = alternativasC[idPergunta];
        respostaD.text = alternativasD[idPergunta];

        infoRespostas.text = "Respondendo " + (idPergunta + 1) + " perguntas " + questoes + " questões";
    }

    public void Resposta(string alternativa)
    {
        if (alternativa == "A")
        {
            if (alternativasA[idPergunta] == corretas[idPergunta])
            {
                acertos++;
            }
        }
        else if (alternativa == "B")
        {
            if (alternativasB[idPergunta] == corretas[idPergunta])
            {
                acertos++;
            }
        }
        else if (alternativa == "C")
        {
            if (alternativasC[idPergunta] == corretas[idPergunta])
            {
                acertos++;
            }

        }
        else if (alternativa == "D")
        {
            if (alternativasD[idPergunta] == corretas[idPergunta])
            {
                acertos++;
            }
        }
        ProximaPergunta();
    }

    public void ProximaPergunta()
    {
        idPergunta++;
        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativasA[idPergunta];
        respostaB.text = alternativasB[idPergunta];
        respostaC.text = alternativasC[idPergunta];
        respostaD.text = alternativasD[idPergunta];
        infoRespostas.text = "Respondendo " + (idPergunta + 1) + " perguntas " + questoes + " questões";
    }
}
