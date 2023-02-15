using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestShaderKeywordBug : MonoBehaviour
{
    public Button Button;
    public TextMeshProUGUI Text;

    private void Awake()
    {
        Button.onClick.AddListener(() =>
        {
            var material = new Material(Text.fontSharedMaterial);
            material.shaderKeywords = Text.fontSharedMaterial.shaderKeywords;
            Text.fontSharedMaterial = material;
        });
    }

    private void Update()
    {
        Text.text = $"Keywords: {string.Join(",", Text.fontSharedMaterial.shaderKeywords)}";
    }
}
