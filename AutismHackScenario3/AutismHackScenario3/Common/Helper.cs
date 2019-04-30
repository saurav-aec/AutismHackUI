using AutismHackScenario3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace AutismHackScenario3.Common
{
    public class StringTable
    {
        public string[] ColumnNames { get; set; }
        public string[,] Values { get; set; }
    }
    public class Helper
    {
        public async Task<Rootobject> InvokeRequestResponseService(ScoreInputModel model)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"Age", "Domain", "SkillTitle", "DomainOrdinal", "SkillOrdinal", "SkillLevel", "DaysToMastery"},
                                Values = new string[,] {  { model.Age, model.Domain, model.SkillTitle, model.DomainOrdinal, model.SkillOrdinal, model.SkillLevel, model.DaysToMastery} }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "p5UIzIRDTZDKwz8W21jwcuxcsWUC4pvwQKZMzhB2lZ9jABgiDpDymRtgb/kKOhyN8pupnzqwzwhp6yxMY7svhQ=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/6a52fb6be2244c358ce891ad4dfc2773/services/c44488bcf108433ab77e4f74df9f235d/execute?api-version=2.0&details=true");


                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var responseStr =  response.Content.ReadAsStringAsync().Result;
                    var returnValue = JsonConvert.DeserializeObject<Rootobject>(responseStr);
                    return returnValue;
                }
                else
                {
                   var result =  response.Content.ReadAsStringAsync().Result;

                    return new Rootobject();
                }
            }
        }
    }
}