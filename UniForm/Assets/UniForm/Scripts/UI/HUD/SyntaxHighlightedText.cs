using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace UniForm.UI.HUD
{
    public class SyntaxHighlightedText : MonoBehaviour
    {
        [SerializeField] bool autoRefresh = true;
        [SerializeField] TMPro.TextMeshProUGUI originalText;
        TMPro.TextMeshProUGUI text;

        private void Awake()
        {
            text = GetComponent<TMPro.TextMeshProUGUI>();
        }

        string SyntaxHighlight(string source)
        {
            //TODO
            Dictionary<string, string> highlightColors = new Dictionary<string, string>();
            highlightColors.Add("printf", "0055FF");
            highlightColors.Add("int", "0055FF");
            highlightColors.Add("float", "0055FF");
            highlightColors.Add("main", "0055FF");
            highlightColors.Add("void", "0055FF");
            highlightColors.Add("return", "0055FF");
            foreach(var pair in highlightColors)
            {
                source = source.Replace(pair.Key, "<color=#" + pair.Value + ">" + pair.Key + "</color>");
            }
            return source;
        }

        public void Refresh()
        {
            text.text = SyntaxHighlight(originalText.text);
        }

        private void Update()
        {
            Refresh();
        }
    }
}
