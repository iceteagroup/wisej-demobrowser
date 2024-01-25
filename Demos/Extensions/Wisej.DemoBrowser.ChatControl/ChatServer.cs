using System;
using System.Collections.Generic;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl
{
	/// <summary>
	/// A sample chat server.
	/// </summary>
	public class ChatServer
	{
		public static string CONVERSATION_ID = "DefaultConversation";

		/// <summary>
		/// Fires when there is an incoming message.
		/// </summary>
		public static event EventHandler<Message> IncomingMessage;

		/// <summary>
		/// Fires when a message is deleted.
		/// </summary>
		public static event EventHandler<Message> DeletedMessage;

		/// <summary>
		/// Fires when a user joins the chat.
		/// </summary>
		public static event EventHandler<User> UserJoined;

		/// <summary>
		/// Fires when a user exits the chat.
		/// </summary>
		public static event EventHandler<User> UserExited;

		public static List<User> OnlineUsers = new List<User>();

		public static Message[] GetMessages()
		{
			return MessageDataManager.GetDefaultMessages();
		}

		/// <summary>
		/// Sends a message on the chat server.
		/// </summary>
		/// <param name="message"></param>
		public static void SendMessage(Message message)
		{
			IncomingMessage?.Invoke(null, message);

			// save to db.
			if (message.ContentType != "typing")
				MessageDataManager.Save(message);
		}

		/// <summary>
		/// Deletes a given message.
		/// </summary>
		/// <param name="message"></param>
		public static void DeleteMessage(Message message) 
		{ 
			DeletedMessage?.Invoke(null, message);

			// delete from db.
		}

		/// <summary>
		/// Connects a user to the chat server.
		/// </summary>
		/// <param name="user"></param>
		public static void Join(User user)
		{
			OnlineUsers.Add(user);

			UserJoined?.Invoke(null, user);
		}

		/// <summary>
		/// Disconnects a user from the chat server.
		/// </summary>
		/// <param name="user"></param>
		public static void Leave(User user)
		{
			OnlineUsers.Remove(user);

			UserExited?.Invoke(null, user);
		}
	}
}
