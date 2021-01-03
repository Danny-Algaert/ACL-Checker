using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_ACL_Checker
{
    class ApiWebFetcher
    {
        private static string characterSearchUrl = "https://esi.evetech.net/latest/search/?categories=character&datasource=tranquility&language=en-us&search=SEARCHTERM&strict=true";
        private static string characterLookupByIdUrl = "https://esi.evetech.net/latest/characters/SEARCHTERM/?datasource=tranquility";
        private static string appPathCharacter = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EVE Paranoia\\Characters\\";
        private static string appPathShortCharacter = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EVE Paranoia\\CharacterID\\";

        public static string GetCharactersCorpByName(string name, TextBox output)
        {
            if (System.IO.File.Exists(appPathShortCharacter + "\\" + name + ".txt") && System.IO.File.GetLastWriteTime(appPathCharacter + "\\" + name + ".txt").AddDays(7) > System.DateTime.Now)
            {
                return JObject.Parse(System.IO.File.ReadAllText(appPathShortCharacter + "\\" + name + ".txt"))["character"].ToString();
            }
            else
            {
                try
                {
                    String characterIdJson = new StreamReader(WebRequest.Create(Regex.Replace(characterSearchUrl,
                         "SEARCHTERM", Regex.Replace(name, @"\s+", "%20"))).GetResponse().GetResponseStream()).ReadToEnd();

                    JObject shortCharacter = JObject.Parse(characterIdJson);
                    JArray a = (JArray)shortCharacter["character"];                    
                    if (a != null && a.Count == 1)
                    {
                        WriteCharacterToFile(name, shortCharacter.ToString(), appPathShortCharacter);
                        return GetCharacterByID(a[0].ToString()).CorporationId;                        
                    }
                    else
                    {
                        output.Text += "Could not find: " + name + " manually check character" + Environment.NewLine;
                        return "";
                    }
                }
                catch
                {
                    output.Text += "Could not find: " + name + " manually check character" + Environment.NewLine;
                    return "";
                }
            }               
        }


        private static Character GetCharacterByID(string id)
        {
            if (System.IO.File.Exists(appPathCharacter + "\\" + id + ".txt") && System.IO.File.GetLastWriteTime(appPathCharacter + "\\" + id + ".txt").AddDays(7) > System.DateTime.Now)
            {
                return GetCharacterFromFile(id);
            }
            else
            {
                String json = new StreamReader(WebRequest.Create(Regex.Replace(characterLookupByIdUrl,
                    "SEARCHTERM", id)).GetResponse().GetResponseStream()).ReadToEnd();
                JObject longCharacter = JObject.Parse(json);
                Character character = CharacterFromJson(id, longCharacter);
                Console.WriteLine(character.ToString() + " from server");

                WriteCharacterToFile(id, json, appPathCharacter);
                return character;
            }
        }

        private static Character CharacterFromJson(string id, JObject json)
        {
            Character character;

            character = new Character(id, json["name"].ToString(), json["alliance_id"].ToString(), json["corporation_id"].ToString(),
                json["gender"].ToString(), json["description"].ToString(), json["birthday"].ToString(),
                Int32.Parse(json["race_id"].ToString()),
                Int32.Parse(json["ancestry_id"].ToString()),
                Int32.Parse(json["bloodline_id"].ToString()));
            return character;
        }

        private static Character GetCharacterFromFile(string id)
        {
            return CharacterFromJson(id, JObject.Parse(System.IO.File.ReadAllText(appPathCharacter + "\\" + id + ".txt")));
        }

        private static void WriteCharacterToFile(string id, string json, string path)
        {
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            System.IO.File.WriteAllText(path + "\\" + id + ".txt", json.ToString());
        }

    

    }
}
