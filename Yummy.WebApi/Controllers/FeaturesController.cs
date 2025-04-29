using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.WebApi.Context;
using Yummy.WebApi.DTOS.FeatureDTO;
using Yummy.WebApi.Entity;

namespace Yummy.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;
        public FeaturesController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _context.Features.ToList();
            return Ok(_mapper.Map<List<ResultFeatureDTO>>(values));
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDTO createFeatureDTO)
        {
            var values = _mapper.Map<Feature>(createFeatureDTO);
            _context.Features.Add(values);
            _context.SaveChanges();
            return Ok("Özellik Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _context.Features.Find(id);
            _context.Features.Remove(value);
            _context.SaveChanges();
            return Ok("Silindi");


        }

        [HttpGet]
        public IActionResult GetFeature(int id)
        {
            var valu = _context.Features.Find(id);
            return Ok(_mapper.Map<GetByIDFeatureDTO>(valu));
        }

        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDTO updateFeatureDTO)
        { 
            var value= _mapper.Map<Feature>(updateFeatureDTO);
            _context.Features.Update(value);
            _context.SaveChanges();
            return Ok("Güncellendi");
        }
    }
}
