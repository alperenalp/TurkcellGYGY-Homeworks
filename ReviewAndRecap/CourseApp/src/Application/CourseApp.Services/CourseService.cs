using AutoMapper;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses()
        {
            var courses = _repository.GetAll();
            //var responses = _mapper.Map<IEnumerable<CourseDisplayResponse>>(courses);
            //var responses = courses.ConvertToDto<IEnumerable<CourseDisplayResponse>>(_mapper);
            var responses = courses.ConvertToDisplayResponses(_mapper);
            return responses;
            
        }
    }
}
