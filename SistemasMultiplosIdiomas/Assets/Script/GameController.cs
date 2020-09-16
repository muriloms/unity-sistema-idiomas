using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameText;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private LoadXMLFile _loadXMLFile;

    [SerializeField] private Text textNomeJogo;
    [SerializeField] private Text textInformacoesJogo;
    [SerializeField] private Text textCreditos;

    private List<string> _textoTelaInicial;
    private void Awake()
    {
        TextosTelaInicial();
    }

    private void TextosTelaInicial()
    {
        _loadXMLFile = new LoadXMLFile();
        _textoTelaInicial = _loadXMLFile.LoadXMLData();
        textNomeJogo.text = _textoTelaInicial[0];
        textInformacoesJogo.text = _textoTelaInicial[1];
        textCreditos.text = _textoTelaInicial[2];
    }

    public void TrocarIdioma(string idioma)
    {
        PlayerPrefs.SetString("idioma", idioma);
        TextosTelaInicial();
    }
}
