﻿using Business.Abstract;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Business.Concrete
{
    public class ApiRoutes : IApiRoutes
    {
        public IDictionary<string,string> GetApiRoutes(string ControllerName)
        {
            IDictionary<string,string> routes = new Dictionary<string,string>();
            string json = System.IO.File.ReadAllText("ApiRoutes.json");
            dynamic jsonObj = JsonConvert.DeserializeObject<dynamic>(json)!;
            var Controllers = jsonObj.ApiRoutes;
            foreach (var Controller in Controllers)
            {
                if(Controller.ControllerName.ToString() == ControllerName)
                {
                    var actions = Controller.Actions;
                    foreach (var action in actions)
                    {
                        routes.Add(action.Name.ToString(), action.Value.ToString());
                    }
                }
            }
            return routes;
        }
    }
}
