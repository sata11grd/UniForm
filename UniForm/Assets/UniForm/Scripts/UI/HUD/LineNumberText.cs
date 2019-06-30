using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace UniForm.UI.HUD
{
    public class LineNumberText : MonoBehaviour
    {
        [SerializeField] TMPro.TMP_InputField inputField;
        TMPro.TextMeshProUGUI text;

        private void Awake()
        {
            text = GetComponent<TMPro.TextMeshProUGUI>();
        }

        private void Update()
        {
            text.text = "";

            int count = inputField.text.Split('\n').Length;
            for(int line = 1; line <= count; line++)
            {
                text.text += line.ToString() + "\n";
            }
        }
    }
}
