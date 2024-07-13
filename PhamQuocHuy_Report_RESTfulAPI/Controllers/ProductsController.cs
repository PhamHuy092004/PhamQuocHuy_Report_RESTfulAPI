using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PhamQuocHuy_Report_RESTfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Tạo 1 hàm get mẫu chứa 2 sản phẩm
        /// <summary>
        /// Lấy danh sách tất cả sản phẩm.
        /// </summary>
        /// <returns>Danh sách sản phẩm.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return new string[] { "product1", "product2" };
        }
    }
}
