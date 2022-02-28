using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WaterProject2.Infrastructure;

namespace WaterProject2.Models
{
    public class SessionBasket : Basket
    {
        //new method to get a basket
        public static Basket GetBasket (IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionBasket basket = session?.GetJson<SessionBasket>("Basket") ?? new SessionBasket();

            basket.Session = session;

            return basket; 
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Project proj, int qty)
        {
            base.AddItem(proj, qty);
            // current instance of the class and also used as a modifier
            Session.SetJson("Basket", this);
        }

        public override void RemoveItem(Project proj)
        {
            base.RemoveItem(proj);
            Session.SetJson("Basket", this);
        }

        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("Basket");
        }
    }
}
