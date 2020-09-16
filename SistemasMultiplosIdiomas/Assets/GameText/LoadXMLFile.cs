using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

namespace GameText
{
    public class LoadXMLFile
    {
        
        public List<string> LoadXMLData()
        {
            
            string idioma = "pt-br";
            if (PlayerPrefs.GetString("idioma") != "")
            {
                idioma = PlayerPrefs.GetString("idioma");
            }
            
            string arquivoXML = "language";
            
            TextAsset xmlData = (TextAsset) Resources.Load(idioma + "/" + arquivoXML);
            XmlDocument _xmlDocument = new XmlDocument();
        
            _xmlDocument.LoadXml(xmlData.text);
            
            List<string> textoTelaInicial = new List<string>();
            foreach (XmlNode node in _xmlDocument["language"].ChildNodes)
            {
                string nodeName = node.Attributes["name"].Value;
                
                foreach (XmlNode n in node["textos"].ChildNodes)
                {
                    textoTelaInicial.Add(n.InnerText);
                }
            }
            Debug.Log(textoTelaInicial.Count);
            return textoTelaInicial;

        }
    }
}

