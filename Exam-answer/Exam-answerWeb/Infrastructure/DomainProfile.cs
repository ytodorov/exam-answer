using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Models;

namespace Exam_answerWeb.Infrastructure
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<ExamEntity, ExamViewModel>().ReverseMap();

            CreateMap<QuestionEntity, QuestionViewModel>().ReverseMap();

            CreateMap<ContentEntity, ContentViewModel>().ReverseMap();

            CreateMap<AnswerEntity, AnswerViewModel>().ReverseMap();

            CreateMap<ExplanationEntity, ExplanationViewModel>().ReverseMap();

            CreateMap<ReferenceEntity, ReferenceViewModel>().ReverseMap();
        }
    }
}