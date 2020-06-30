﻿using DAL.Entities;
using Exam_answerWeb.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Infrastructure
{
    public static class HelperMethods
    {
        public static List<QuestionViewModel> GetSimilarQuestions(QuestionViewModel questionEntity, ExamViewModel examEntity)
        {
            ExamViewModel theExam = examEntity;

            List<QuestionViewModel> allquestions = theExam.Questions;

            //List<double> distances = new List<double>();

            //List<Tuple<QuestionViewModel, QuestionViewModel, string>> duplicatesLists =
            //     new List<Tuple<QuestionViewModel, QuestionViewModel, string>>();

            ConcurrentBag<Tuple<QuestionViewModel, QuestionViewModel, double>> distanceListAllQuestions =
                 new ConcurrentBag<Tuple<QuestionViewModel, QuestionViewModel, double>>();

            Parallel.For(0, allquestions.Count - 1, (j) =>

            //for (int j = 0; j < allquestions.Count; j++)
            {
                QuestionViewModel q2 = allquestions[j];
                if (questionEntity.Order != q2.Order)
                {
                    string text1 = questionEntity.ContentText.Replace(" ", string.Empty);// + questionEntity.AnswerText.Replace(" ", string.Empty);

                    string text2 = q2.ContentText.Replace(" ", string.Empty);// + q2.AnswerText.Replace(" ", string.Empty);

                    string helperTextForDebug = $"{questionEntity.Id + 1}{text1}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{q2.Id + 1}{text2}";

                    double distance = LevenshteinDistance.CalculateSimilarity(text1, text2);
                    //distances.Add(Math.Round(distance, 2));
                    //if (distance > 0.81)
                    //{
                    //    duplicatesLists.Add(new Tuple<QuestionViewModel, QuestionViewModel, string>(
                    //        questionEntity, q2, distance.ToString()));

                    //    string textToSee = $"{text1} {Environment.NewLine}{Environment.NewLine} {text2}";
                    //}

                    distanceListAllQuestions.Add(new Tuple<QuestionViewModel, QuestionViewModel, double>(
                            questionEntity, q2, distance));
                }
            });
            //string duplicateResultHelper = string.Join("\r\n\r\n\r\n", duplicatesLists.Select(s => s.Item1.ContentText + " ----- " + s.Item2.ContentText).ToList());

            //distances = distances.OrderByDescending(d => d).ToList();

            var distanceListAllQuestionsList = distanceListAllQuestions.ToList().OrderByDescending(d => d.Item3);

            var top3Distances = distanceListAllQuestionsList
                .Where(s => s.Item3 > 0.5)
                .Take(3)
                .ToList();

            List<QuestionViewModel> result = top3Distances.Select(s => s.Item2).ToList();
            return result;
        }
    }
}
