using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAdminAppTest.Fixtures;

namespace WebAdminAppTest.Controler
{
    public class AdminControllerTests: IClassFixture<ApiWebApplicationFactory>
    {
        HttpClient _httpClient = new HttpClient();
        public AdminControllerTests()
        {
            ApiWebApplicationFactory _factory = new ApiWebApplicationFactory();
            _httpClient = _factory.CreateClient();
        }

    }
}
