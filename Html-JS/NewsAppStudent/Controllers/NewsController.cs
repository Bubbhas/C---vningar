using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Models;

namespace NewsApp.Controllers
{
    [Route("api/news")]
    public class NewsController : Controller
    {
        private NewsRepository _newsRepository;

        public NewsController(NewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        [HttpPost("seed")]
        public IActionResult Seed()
        {
            throw new NotImplementedException();
        }

        [HttpPost("recreate")]
        public IActionResult RecreateDatabase()
        {
            _newsRepository.RecreateDatabase();
            return Ok();
        }

        [HttpGet("count")]
        public IActionResult Count()
        {
            var amount = _newsRepository.CountAll();

           return Ok(amount);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            IEnumerable<News> news = _newsRepository.GetAll();
            return Ok(news);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //int ID = _newsRepository.GetById

            //return Ok(idNumner);
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Add([FromBody]News news)
        {
            if (string.IsNullOrEmpty(news.Header) || string.IsNullOrEmpty(news.Intro) || string.IsNullOrEmpty(news.Body))
            {
                return BadRequest("Du måste fylla i alla fält!");
            }
            else    if(news.Header.Length < 5 || news.Header.Length > 20)
            {
                return BadRequest("Måste vara mellan 5-20 tecken");
            }
            else
            {
                news.Created = DateTime.Now;
                _newsRepository.Add(news);
                return Ok(news.Id);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody]News news) // api/news
        {
            news.Updated = DateTime.Now;
            _newsRepository.Update(news);
            return Ok(news.Id);
        }

        [HttpDelete("{id}")] // api/news/123
        public IActionResult Remove(int id)
        {
            _newsRepository.Remove(id);
            return Ok();
        }

    }
}
