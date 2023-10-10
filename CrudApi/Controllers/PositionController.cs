using Crud_UI.Models;
using CrudApi.DAL.Interface;
using CrudApi.Dtos;
using CrudApi.SMTP.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        IPositionDal _positionDal;
        IEmailService _emailService;
        public PositionController(IPositionDal positionDal, IEmailService emailService)
        {
            _positionDal = positionDal;
            _emailService = emailService;   
        }
        [HttpPost("Add-Position")]
        public async Task<bool> AddPosition(Position position,string companyName)
        {
            bool data = _positionDal.AddPositions(position);
            EmailDto sendingEmail = new EmailDto()
            {
                To = "recai.capkin28@gmail.com",
                Subject = "Position Add",
                PlaceHolders = new List<KeyValuePair<string, string>>() {
                    new KeyValuePair<string, string>("firma", companyName),
                    new KeyValuePair<string, string>("pozisyon",position.PositionName),
                    new KeyValuePair<string, string>("zaman",DateTime.Now.ToString())
                }

            };
            _emailService.SendEmail(sendingEmail);
            return data;
        }
    }
}
