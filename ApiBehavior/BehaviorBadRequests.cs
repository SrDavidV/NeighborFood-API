using Microsoft.AspNetCore.Mvc;

namespace NeighbodFood2.ApiBehavior
{
    public class BehaviorBadRequests
    {
        public static void Parsear(ApiBehaviorOptions options)
        {
            options.InvalidModelStateResponseFactory = ActionContext =>
            {
                var respueta = new List<string>();
                foreach (var llave in ActionContext.ModelState.Keys)
                {
                    foreach (var error in ActionContext.ModelState[llave].Errors)
                    {
                        respueta.Add(error.ErrorMessage);
                    }
                }
                return new BadRequestObjectResult(respueta);
            };
        }
    }
}
