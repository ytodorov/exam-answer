﻿using DAL.Entities;
using Exam_answerWeb.Infrastructure.crt251;
using Exam_answerWeb.Infrastructure.Questions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

//using Exam_answerWeb.Infrastructure.Questions;

namespace Exam_answerWeb.Infrastructure
{
    public class DataGenerator
    {
        public static List<ExamEntity> AllExams;

        private static List<QuestionEntity> GetQuestions(string path, int startOrder = 0)
        {
            string allText = File.ReadAllText(path);

            allText = allText.Replace(char.ConvertFromUtf32(8203), string.Empty);

            var quesions = allText.Split("###", StringSplitOptions.RemoveEmptyEntries).ToList(); ;

            List<QuestionEntity> qeList = new List<QuestionEntity>();
            foreach (string question in quesions)
            {
                string[] questionsGroups = question.Split($"---", StringSplitOptions.RemoveEmptyEntries);

                List<string> questionContent = questionsGroups[0].Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (questionContent.Count == 0)
                {
                    continue;
                }
                List<string> questionAnswers = questionsGroups[1].Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (questionAnswers.Any(s => s == "Off and On"))
                {

                }
                questionAnswers = questionAnswers.Where(s => !string.IsNullOrEmpty(s.Trim())).ToList();
                List<string> questionExplanations = questionsGroups[2].Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
                questionExplanations = questionExplanations.Where(s => !string.IsNullOrEmpty(s.Trim())).ToList();
                List<string> questionReferences = questionsGroups[3].Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
                questionReferences = questionReferences.Where(s => !string.IsNullOrEmpty(s.Trim())).ToList();

                QuestionEntity qe = new QuestionEntity();
                qe.Order = startOrder + 1 + quesions.IndexOf(question);
                if (questionContent.FirstOrDefault()?.Equals("C") == true)
                {
                    qe.QuestionType = QuestionType.CheckBox;
                    questionContent = questionContent.Skip(1).ToList();
                }
                else if (questionContent.FirstOrDefault()?.Equals("D") == true)
                {
                    qe.QuestionType = QuestionType.DropDown;
                    questionContent = questionContent.Skip(1).ToList();
                }


                foreach (string content in questionContent)
                {
                    ContentEntity contentEntity = new ContentEntity()
                    {
                        Text = content,
                        Order = questionContent.IndexOf(content),
                    };
                    qe.Contents.Add(contentEntity);
                }

                foreach (string answer in questionAnswers)
                {
                    AnswerEntity answerEntity = new AnswerEntity()
                    {
                        Text = answer,
                        Order = questionAnswers.IndexOf(answer),
                    };
                    if (answer.EndsWith("*"))
                    {
                        answerEntity.IsCorrect = true;
                        answerEntity.Text = answer.TrimEnd('*').Trim();
                    }
                    qe.Answers.Add(answerEntity);
                }

                foreach (string explanation in questionExplanations)
                {
                    ExplanationEntity explanationEntity = new ExplanationEntity()
                    {
                        Text = explanation,
                        Order = questionExplanations.IndexOf(explanation),
                    };
                    qe.Explanations.Add(explanationEntity);
                }

                foreach (string reference in questionReferences)
                {
                    if (reference.Length > 10)
                    {
                        ReferenceEntity referenceEntity = null;
                        if (reference.Contains(";"))
                        {
                            List<string> parts = reference.Split(";").ToList();
                            referenceEntity = new ReferenceEntity()
                            {
                                Text = parts[0],
                                Url = parts[1],
                                Order = questionReferences.IndexOf(reference),
                            };
                        }
                        else
                        {
                            referenceEntity = new ReferenceEntity()
                            {
                                Text = reference,
                                Url = reference,
                                Order = questionReferences.IndexOf(reference),
                            };
                        }
                        qe.References.Add(referenceEntity);
                    }
                }

                qeList.Add(qe);
            }

            return qeList;
        }

        public static List<ExamEntity> Initialize(ExamAnswerContext context)
        {

            string allText = File.ReadAllText("Exams\\Salesforce-Certified-Field-Service-Lightning-Consultant.txt");

            var quesions = allText.Split("###", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<QuestionEntity> qeList = new List<QuestionEntity>();
            foreach (string question in quesions)
            {
                string[] questionsGroups = question.Split($"---", StringSplitOptions.RemoveEmptyEntries);

                List<string> questionContent = questionsGroups[0].Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> questionAnswers = questionsGroups[1].Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
                //var questionExplanations = questionsGroups[2].Split(Environment.NewLine);
                //var questionReferences = questionsGroups[3].Split(Environment.NewLine);
                QuestionEntity qe = new QuestionEntity();
                qe.Order = quesions.IndexOf(question);
                if (questionContent.FirstOrDefault()?.Equals("C") == true)
                {
                    qe.QuestionType = QuestionType.CheckBox;
                    questionContent = questionContent.Skip(1).ToList();
                }

                foreach (string content in questionContent)
                {
                    ContentEntity contentEntity = new ContentEntity()
                    {
                        Text = content,
                        Order = questionContent.IndexOf(content),
                    };
                    qe.Contents.Add(contentEntity);
                }

                foreach (string answer in questionAnswers)
                {
                    AnswerEntity answerEntity = new AnswerEntity()
                    {
                        Text = answer,
                        Order = questionAnswers.IndexOf(answer),
                    };
                    if (answer.EndsWith("*"))
                    {
                        answerEntity.IsCorrect = true;
                        answerEntity.Text = answer.TrimEnd('*').Trim();
                    }
                    qe.Answers.Add(answerEntity);
                }

                qeList.Add(qe);
            }

            List<ExamEntity> result = new List<ExamEntity>();

            //ExamEntity adm201 = new ExamEntity()
            //{
            //    Provider = "Salesforce",
            //    ExamProviderUrl = "https://www.exam-answer.com/salesforce",
            //    ExamUrl = "https://www.exam-answer.com/salesforce/adm-201",
            //    Code = "ADM-201",
            //    Name = "Administration Essentials for New Admins",
            //    PageTitle = "Exam ADM-201: Administration Essentials for New Admins",
            //    PageDescription = "Prepare for Exam ADM-201: Administration Essentials for New Admins. Free demo questions with answers and explanations.",
            //    Questions = GetQuestions("Exams\\adm-201.txt"),
            //    Order = 3,
            //};

            //context?.Exams?.Add(adm201);
            //result.Add(adm201);

            //ExamEntity saa_c01 = new ExamEntity()
            //{
            //    Provider = "Amazon",
            //    Code = "SAA-C01",
            //    Name = "AWS Certified Solutions Architect - Associate",
            //    ExamProviderUrl = "https://www.exam-answer.com/amazon",
            //    ExamUrl = "https://www.exam-answer.com/amazon/saa-c01",
            //    PageTitle = "Exam SAA-C01: AWS Certified Solutions Architect – Associate",
            //    PageDescription = "Prepare for Exam SAA-C01: AWS Certified Solutions Architect – Associate. Free demo questions with answers and explanations.",
            //    Questions = GetQuestions("Exams\\SAA-C01.txt"),
            //    Order = 1,
            //};

            //context?.Exams?.Add(saa_c01);
            //result.Add(saa_c01);

            //ExamEntity saa_c02 = new ExamEntity()
            //{
            //    Provider = "Amazon",
            //    Code = "SAA-C02",
            //    Name = "AWS Certified Solutions Architect - Associate",
            //    ExamProviderUrl = "https://www.exam-answer.com/amazon",
            //    ExamUrl = "https://www.exam-answer.com/amazon/saa-c02",
            //    PageTitle = "Exam SAA-C02: AWS Certified Solutions Architect – Associate",
            //    PageDescription = "Prepare for Exam SAA-C02: AWS Certified Solutions Architect – Associate. Free demo questions with answers and explanations.",
            //    Questions = GetQuestions("Exams\\SAA-C02.txt"),
            //    Order = 2,
            //};

            //context?.Exams?.Add(saa_c02);
            //result.Add(saa_c02);

            //ExamEntity slf_c01 = new ExamEntity()
            //{
            //    Provider = "Amazon",
            //    Code = "CLF-C01",
            //    Name = "AWS Certified Cloud Practitioner",
            //    ExamProviderUrl = "https://www.exam-answer.com/amazon",
            //    ExamUrl = "https://www.exam-answer.com/amazon/clf-c01",
            //    PageTitle = "Exam CLF-C01: AWS Certified Cloud Practitioner",
            //    PageDescription = "Prepare for Exam CLF-C01: AWS Certified Cloud Practitioner. Free demo questions with answers and explanations.",
            //    Questions = GetQuestions("Exams\\CLF-C01.txt"),
            //    Order = 3,
            //};

            //context?.Exams?.Add(slf_c01);
            //result.Add(slf_c01);

            ExamEntity az104 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-104",
                Name = "Microsoft Azure Administrator",
                ExamProviderUrl = "https://www.exam-answer.com/microsoft",
                ExamUrl = "https://www.exam-answer.com/microsoft/az-104",
                PageTitle = "Exam AZ-104: Microsoft Azure Administrator",
                PageDescription = "Prepare for Exam AZ-104: Microsoft Azure Administrator. Free demo questions with answers and explanations.",
                Questions = GetQuestions("Exams\\az-104.txt"),
                Order = 2,
            };

            context?.Exams?.Add(az104);
            result.Add(az104);

        
            ExamEntity az300 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-300",
                Name = "Microsoft Azure Architect Technologies",
                ExamProviderUrl = "https://www.exam-answer.com/microsoft",
                ExamUrl = "https://www.exam-answer.com/microsoft/az-300",
                PageTitle = "Exam AZ-300: Microsoft Azure Architect Technologies",
                PageDescription = "Prepare for Exam AZ-300: Microsoft Azure Architect Technologies. Free demo questions with answers and explanations.",
                Questions = GetQuestions("Exams\\az-300.txt"),
                Order = 2,
            };

            context?.Exams?.Add(az300);
            result.Add(az300);


            // 303

            ExamEntity az303 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-303",
                Name = "Microsoft Azure Architect Technologies",
                ExamProviderUrl = "https://www.exam-answer.com/microsoft",
                ExamUrl = "https://www.exam-answer.com/microsoft/az-303",
                PageTitle = "Exam AZ-303: Microsoft Azure Architect Technologies",
                PageDescription = "Prepare for Exam AZ-303: Microsoft Azure Architect Technologies. Free demo questions with answers and explanations.",
                Questions = GetQuestions("Exams\\az-303.txt"),
                Order = 4,
            };

            context?.Exams?.Add(az303);
            result.Add(az303);

            ExamEntity az400 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-400",
                ExamProviderUrl = "https://www.exam-answer.com/microsoft",
                ExamUrl = "https://www.exam-answer.com/microsoft/az-400",
                Name = "Designing and Implementing Microsoft DevOps Solutions",
                PageTitle = "Exam AZ-400: Designing and Implementing Microsoft DevOps Solutions",
                PageDescription = "Prepare for Exam AZ-400: Designing and Implementing Microsoft DevOps Solutions. Free demo questions with answers and explanations.",
                Questions = GetQuestions("Exams\\az-400.txt"),
                Order = 5,
            };


            //

            context?.Exams?.Add(az400);
            result.Add(az400);

            ExamEntity az100 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-100",
                ExamProviderUrl = "https://www.exam-answer.com/microsoft",
                ExamUrl = "https://www.exam-answer.com/microsoft/az-100",
                Name = "Microsoft Azure Infrastructure and Deployment",
                PageTitle = "Exam AZ-100: Microsoft Azure Infrastructure and Deployment",
                PageDescription = "Prepare for Exam AZ-100: Microsoft Azure Infrastructure and Deployment. Free demo questions with answers and explanations.",
                Questions = GetQuestions("Exams\\az-100.txt"),
                Order = 1,
            };

            context?.Exams?.Add(az100);
            result.Add(az100);

            ExamEntity az301 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-301",
                ExamProviderUrl = "https://www.exam-answer.com/microsoft",
                ExamUrl = "https://www.exam-answer.com/microsoft/az-301",
                Name = "Microsoft Azure Architect Design",
                PageTitle = "Exam AZ-301: Microsoft Azure Architect Design",
                PageDescription = "Prepare for Exam AZ-301: Microsoft Azure Architect Design. Free demo questions with answers and explanations.",
                Questions = GetQuestions("Exams\\az-301.txt"),
                Order = 3,
            };

            context?.Exams?.Add(az301);
            result.Add(az301);

            ExamEntity az900 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-900",
                ExamProviderUrl = "https://www.exam-answer.com/microsoft",
                ExamUrl = "https://www.exam-answer.com/microsoft/az-900",
                Name = "Microsoft Azure Fundamentals",
                PageTitle = "Exam AZ-900: Microsoft Azure Fundamentals",
                PageDescription = "Prepare for Exam AZ-900: Microsoft Azure Fundamentals. Free demo questions with answers and explanations.",
                Questions = new List<QuestionEntity>(),
                Order = 5,
            };


            az900.ShowUdemy = false;
            az900.UdemyLinkUrl = "https://www.udemy.com/course/exam-az-900-microsoft-azure-fundamentals-exam-questions/?couponCode=50_OFF";
            az900.UdemyLinkMessage = "Exam AZ-900: Microsoft Azure Fundamentals, Exam Question - 50 % OFF";
            az900.UdemyMessage =
                "If you like what you see, please support the future development of our web site by buying this practice test at Udemy." +
                " Click this link for a 50% discount. The price is ONLY 12.99!";

            List<FieldInfo> az900Fields = typeof(Az900).GetFields(BindingFlags.Static |
                                                      BindingFlags.Public |
                                                      BindingFlags.NonPublic).ToList();

            az900Fields = az900Fields.OrderBy(a =>
            {
                int order = int.Parse(a.Name.Replace("Q", string.Empty).Replace("Instance", string.Empty));
                return order;

            }).ToList();

            foreach (FieldInfo f in az900Fields)
            {
                QuestionEntity qe = f.GetValue(null) as QuestionEntity;
                az900.Questions.Add(qe);
            }

            az900.Questions.AddRange(GetQuestions("Exams\\az-900.txt", az900.Questions.Count));

            context?.Exams?.Add(az900);
            result.Add(az900);

            context?.SaveChanges();

            AllExams = result;
            return result;
        }
    }
}