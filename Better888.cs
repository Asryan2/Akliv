using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vilka
{
	class Better888 : IBetter

	{
		private string _allEventsApiUrl = "https://e4-api.kambi.com/offering/api/v3/888/listView/football.json?lang=en_GB&market=ZZ";

		public List<Event> GetAllEvents()
		{
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(_allEventsApiUrl);
			request.Method = "GET";
			string json;
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			{
				Stream dataStream = response.GetResponseStream();
				StreamReader reader = new StreamReader(dataStream);
				json = reader.ReadToEnd();
				reader.Close();
				dataStream.Close();
			}
			JObject obj;
			try
			{
				 obj = JObject.Parse(json);
				foreach (var item in obj["events"])
				{
					JObject itemObj = ((JObject)item);
					JObject eventObj = (JObject)itemObj["event"];
					Event ev = new Event();
					ev.Home = eventObj["homeName"].ToObject<string>();
					ev.Away = eventObj["awayName"].ToObject<string>();
					//ev.Sport = 
					//JArray paths = ((JArray)eventObj["path"]);
					//int pathCount = paths.Count();
					//string regionName;
					//string leagueName;
					//if (pathCount == 2)
					//{
					//	leagueName = ((JObject)paths[1])["name"].ToObject<string>();
					//}
					//else
					//{
					//	regionName = ((JObject)paths[1])["name"].ToObject<string>();
					//	leagueName = ((JObject)paths[2])["name"].ToObject<string>();
					//}
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("888 invalid json, or changed json formatting");
				return new List<Event>();
			}
			return new List<Event>();
		}

		public List<Event> GetEventBetOffers(int eventID)
		{
			
		}
	}
}
