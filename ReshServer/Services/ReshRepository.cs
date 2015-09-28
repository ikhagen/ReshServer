using System;
using ReshServer.ReshService;
using Newtonsoft.Json;

namespace ReshServer.Services
{
    public class ReshRepository
    {
        public ReshUnit getUnitById(int id)
        {
            //Kan ikke tro at dette er riktig måte å gjøre det på, med passordet i klartekst og det 
            //Usikker på om "WSHttpBinding_IReshService" er riktig 
            ReshServiceClient client = new ReshServiceClient("WSHttpBinding_IReshService");
            client.ClientCredentials.UserName.UserName = "webservice";

            //Vet ikke hva DateTime gjør
            ReshUnit unit = client.GetReshUnit(id, true, false, DateTime.Today);

            client.Close();
            return unit;
        }
    }
}