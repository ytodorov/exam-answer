using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Models;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<ExamEntity, ExamViewModel>().ReverseMap();

            CreateMap<List<ExamEntity>, List<ExamViewModel>>().ReverseMap();

            CreateMap<QuestionEntity, QuestionViewModel>().ReverseMap();

            CreateMap<ContentEntity, ContentViewModel>().ReverseMap();

            CreateMap<AnswerEntity, AnswerViewModel>().ReverseMap();

            CreateMap<ExplanationEntity, ExplanationViewModel>().ReverseMap();

            CreateMap<ReferenceEntity, ReferenceViewModel>().ReverseMap();
        }
    }
}