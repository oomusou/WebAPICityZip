using System.Collections.Generic;
using CityZip.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityZip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityZipController : ControllerBase
    {
        // GET api/cityzip/
        [HttpGet]
        public ActionResult<List<City>> Get()
        {
            return new List<City>
            {
                new City
                {
                    Name = "基隆市",
                    Areas = new List<Area>
                    {
                        new Area {Name = "仁愛區", Zip = "200"},
                        new Area {Name = "信義區", Zip = "201"},
                        new Area {Name = "中正區", Zip = "202"},
                        new Area {Name = "中山區", Zip = "203"},
                        new Area {Name = "安樂區", Zip = "204"},
                        new Area {Name = "暖暖區", Zip = "205"},
                        new Area {Name = "七堵區", Zip = "206"}
                    }
                },
                new City
                {
                    Name = "台北市",
                    Areas = new List<Area>
                    {
                        new Area {Name = "中正區", Zip = "300"},
                        new Area {Name = "大同區", Zip = "301"},
                        new Area {Name = "中山區", Zip = "302"},
                        new Area {Name = "松山區", Zip = "303"},
                        new Area {Name = "大安區", Zip = "304"},
                        new Area {Name = "萬華區", Zip = "305"},
                        new Area {Name = "信義區", Zip = "306"},
                        new Area {Name = "士林區", Zip = "307"},
                        new Area {Name = "北投區", Zip = "307"},
                        new Area {Name = "內湖區", Zip = "308"},
                        new Area {Name = "南港區", Zip = "309"},
                        new Area {Name = "文山區", Zip = "310"}
                    }
                },
                new City
                {
                    Name = "新竹市",
                    Areas = new List<Area>
                    {
                        new Area {Name = "新竹市", Zip = "400"}
                    }
                }
            };
        }
    }
}