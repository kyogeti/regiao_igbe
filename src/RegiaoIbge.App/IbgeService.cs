using System;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace RegiaoIbge.App
{
    public class IbgeService
    {
        private RestClient client;
        private string _mesorregiao = null;
        private Uf? _uf = null;


        public void GetIgbe(string CodigoMunicipioIbge)
        {
            client = new RestClient();

            var request = new RestRequest($"https://servicodados.ibge.gov.br/api/v1/localidades/municipios/${CodigoMunicipioIbge}", Method.GET);

            var response = client.Get(request);

            if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
            {
                var result = JObject.Parse(response.Content);
                if (result.ContainsKey("microrregiao"))
                {
                    _mesorregiao = result["microrregiao"]["mesorregiao"]["nome"].ToString();
                    _uf = (Uf)Convert.ToInt32(result["microrregiao"]["mesorregiao"]["UF"]["id"].ToString());
                }
            }
        }

        public string GetMesorregiao()
        {
            return _mesorregiao;
        }

        public Uf? GetUf()
        {
            return _uf;
        }
    }
}