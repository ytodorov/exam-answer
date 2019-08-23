
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q79Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 205,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have the Azure virtual machines shown in the following table.",
                },
                new ContentEntity()
                {
                    Text = "You have a Recovery Services vault that protects VM1 and VM2.",
                },
                new ContentEntity()
                {
                    Text = "You need to protect VM3 and VM4 by using Recovery Services.",
                },
                new ContentEntity()
                {
                    Text = "What should you do first?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a new backup policy.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Configure the extensions for VM3 and VM4.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a storage account.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a new Recovery Services vault.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "A Recovery Services vault is a storage entity in Azure that houses data. The data is typically copies of data, or configuration information for virtual machines (VMs),"
                },
                new ExplanationEntity()
                {
                    Text = "workloads, servers, or workstations. You can use Recovery Services vaults to hold backup data for various Azure services"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/site-recovery/azure-to-azure-tutorial-enable-replication",
                },
            },           
        };
    }
}
