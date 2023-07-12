using System;
using System.Collections.Generic;
using System.IO;

class IniFile
{
    private string filePath;
    private Dictionary<string, Dictionary<string, string>> sections;

    public IniFile(string filePath)
    {
        this.filePath = filePath;
        sections = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
        LoadIniFile();
    }

    private void LoadIniFile()
    {
        sections.Clear();

        if (!File.Exists(filePath))
            return;

        string[] lines = File.ReadAllLines(filePath);

        string currentSection = null;
        foreach (string line in lines)
        {
            string trimmedLine = line.Trim();
            if (trimmedLine.StartsWith(";") || string.IsNullOrEmpty(trimmedLine))
                continue;

            if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
            {
                currentSection = trimmedLine.Substring(1, trimmedLine.Length - 2);
                sections[currentSection] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            }
            else if (currentSection != null)
            {
                int equalIndex = trimmedLine.IndexOf('=');
                if (equalIndex != -1)
                {
                    string key = trimmedLine.Substring(0, equalIndex).Trim();
                    string value = trimmedLine.Substring(equalIndex + 1).Trim();
                    sections[currentSection][key] = value;
                }
            }
        }
    }

    public void SetValue(string section, string key, string value)
    {
        if (!sections.ContainsKey(section))
            sections[section] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        sections[section][key] = value;
    }

    public void SaveIniFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (KeyValuePair<string, Dictionary<string, string>> section in sections)
            {
                writer.WriteLine($"[{section.Key}]");

                foreach (KeyValuePair<string, string> keyValue in section.Value)
                    writer.WriteLine($"{keyValue.Key}={keyValue.Value}");

                writer.WriteLine();
            }
        }
    }

    public string GetValue(string section, string key)
    {
        if (sections.ContainsKey(section) && sections[section].ContainsKey(key))
            return sections[section][key];

        return null;
    }
}

class Program
{
    static void Main()
    {
        string filePath = "chimera.ini";
        IniFile iniFile = new IniFile(filePath);

        // Definir la opción y el valor que deseas modificar
        string section = "CustomSection";
        string key = "enabled";
        string newValue = "0";

        // Leer el valor actual
        string currentValue = iniFile.GetValue(section, key);
        Console.WriteLine($"Valor actual de [{section}] {key}: {currentValue}");

        // Modificar el valor
        iniFile.SetValue(section, key, newValue);
        iniFile.SaveIniFile();
        Console.WriteLine($"Valor modificado a [{section}] {key}: {newValue}");
    }
}