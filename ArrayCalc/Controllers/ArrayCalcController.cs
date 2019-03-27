using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArrayCalc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArrayCalc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        // GET api/ArrayCalc/Reverse
        [HttpGet]
        [Route("[action]")]
        public ActionResult<string> Reverse(int[] productIds)
        {
            try
            {
                if (productIds != null && productIds.Count() > 0)
                {
                    ArrayOperator arrayOperator = new ArrayOperator();
                    //Reversing the array
                    arrayOperator.Reverse(productIds);
                    //Returns the reversed array
                    return Content($"[{string.Join(",", productIds)}]");
                }
                else
                {
                    return Content(string.Empty);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry! An error occurred while reversing the product!\nError:" + ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<string> DeletePart(int position, int[] productIds)
        {
            try
            {
                if (productIds != null && productIds.Count() > 0)
                {
                    if (position > 0 && position - 1 < productIds.Count())
                    {
                        ArrayOperator arrayOperator = new ArrayOperator();                        
                        return Content($"[{string.Join(",", arrayOperator.RemoveElementAt(position, productIds))}]");
                    }
                    else
                    {
                        return Content($"[{string.Join(",", productIds)}]");
                    }
                }
                else
                {
                    return Content(string.Empty);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry!An error occurred while deleting the productId!\nError: " + ex.Message);
            }
        }
    }
}