using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Wisej.Core;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl
{
	public class MessageDataManager
	{
        private static Stream ResourceStream => Assembly.GetExecutingAssembly().GetManifestResourceStream("Wisej.DemoBrowser.ChatControl.Data.Conversation.json");

        public static Message[] GetDefaultMessages()
		{
            // Read text from embedded resource.
            var text = Application.Session["Messages"] != null ? Application.Session["Messages"] : ReadText(ResourceStream);

            return JsonConvert.DeserializeObject<Message[]>(text);
        }

        private static string ReadText(Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static void Save(Message message)
        {
            var text = Application.Session["Messages"] != null ? Application.Session["Messages"] : ReadText(ResourceStream);
            var json = (object[])WisejSerializer.Parse(text);
            var newJson = new dynamic[json.Length + 1];

            Array.Copy(json, newJson, json.Length);

            newJson[newJson.Length - 1] = message;

            Application.Session["Messages"] = WisejSerializer.Serialize(newJson, WisejSerializerOptions.Formatted);
        }
	}
}
