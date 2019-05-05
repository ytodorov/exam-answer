using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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