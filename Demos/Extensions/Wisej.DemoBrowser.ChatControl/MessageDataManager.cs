using System;
using System.IO;
using Newtonsoft.Json;
using Wisej.Core;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl
{
	public class MessageDataManager
	{

		private static string PATH = Application.MapPath("Data/Conversation.json");

		public static Message[] GetDefaultMessages()
		{
            // Read text from embedded resource.
            // 
            var text = File.ReadAllText(PATH);

            return JsonConvert.DeserializeObject<Message[]>(text);
		}

		public static void Save(Message message)
		{
			var text = File.ReadAllText(PATH);
			var json = (object[])WisejSerializer.Parse(text);
			var newJson = new dynamic[json.Length + 1];

			Array.Copy(json, newJson, json.Length);

			newJson[newJson.Length - 1] = message;

			File.WriteAllText(PATH, WisejSerializer.Serialize(newJson, WisejSerializerOptions.Formatted));
		}
	}
}
